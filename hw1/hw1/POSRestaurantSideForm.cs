using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSCustomerSide
{
    public partial class RestaurantSideForm : Form
    {
        private RestaurantSidePresentationModel _model;
        const string ADD = "Add";
        const string SAVE = "Save";
        const char SLASH = '\\';

        public RestaurantSideForm(RestaurantSidePresentationModel model)
        {
            this._model = model;
            InitializeComponent();
            _model._menuChangedRestaurant += UpdateMealListBox;
            _model._menuChangedRestaurant += UpdateCategoryListBox;
            _browseButton.Click += ClickBrowseButton;
            _mealListBox.Click += ClickMealListBox;
            _categoryListBox.Click += ClickCategoryListBox;
            _mealDescriptionTextBox.TextChanged += OnMealTextBoxChanged;
            _mealImageTextBox.TextChanged += OnMealTextBoxChanged;
            _mealNameTextBox.TextChanged += OnMealTextBoxChanged;
            _mealPriceTextBox.TextChanged += OnMealTextBoxChanged;
            _mealCategoryComboBox.TextChanged += OnMealComboBoxChanged;
            _categoryNameTextBox.TextChanged += OnCategoryTextBoxChanged;
            _saveButton1.Click += ClickMealSaveButton;
            _saveButton2.Click += ClickCategorySaveButton;
            _deleteMealButton.Click += ClickDeleteMealButton;
            _deleteCategoryButton.Click += ClickDeleteCategoryButton;
            _addMealButton.Click += ClickAddMealModeButton;
            _addCategoryButton.Click += ClickAddCategoryModeButton;
            _model._menuChangedRestaurant += UpdateMealListBox;
            _model._menuChangedRestaurant += UpdateCategoryListBox;
            _model._categoryChangedRestaurant += UpdateCategoryListBox;
            _model._categoryChangedRestaurant += UpdateMealListBox;
            UpdateMealListBox();
            UpdateCategoryListBox();
        }

        //更新餐點
        private void UpdateMealListBox()
        {
            _mealListBox.Items.Clear();
            List<Meal> menu = _model.GetMenu();
            menu.ForEach(x =>
            {
                _mealListBox.Items.Add(x.Name);
            });
        }

        //更新類別
        private void UpdateCategoryListBox()
        {
            _categoryListBox.Items.Clear();
            _mealCategoryComboBox.Items.Clear();
            List<string> categories = _model.GetCategories();
            categories.ForEach(x =>
            {
                _categoryListBox.Items.Add(x);
                _mealCategoryComboBox.Items.Add(x);
            });
        }

        //按下meal listbox
        private void ClickMealListBox(object sender, EventArgs e)
        {
            ListBox mealListBox = (ListBox)sender;
            if (mealListBox.SelectedItem == null)
                return;
            Meal selectedMeal = _model.FindMealByName(mealListBox.SelectedItem.ToString());
            _mealNameTextBox.Text = selectedMeal.Name;
            _mealPriceTextBox.Text = selectedMeal.Price.ToString();
            _mealImageTextBox.Text = selectedMeal.ImageRelativePath;
            _mealDescriptionTextBox.Text = selectedMeal.Description;
            _mealCategoryComboBox.SelectedItem = selectedMeal.Category.Name;
            _saveButton1.Enabled = false;
            _browseButton.Enabled = true;
            _deleteMealButton.Enabled = true;
        }

        //按下category listbox
        private void ClickCategoryListBox(object sender, EventArgs e)
        {
            _categoryUsingListBox.Items.Clear();
            ListBox categoryListBox = (ListBox)sender;
            if (categoryListBox.SelectedItem == null)
                return;
            _model.GetMealsInCategory(categoryListBox.SelectedItem.ToString()).ForEach(x =>
            {
                _categoryUsingListBox.Items.Add(x);
            });
            _categoryNameTextBox.Text = categoryListBox.SelectedItem.ToString();
            _saveButton1.Enabled = false;
            if (_categoryUsingListBox.Items.Count == 0)
                _deleteCategoryButton.Enabled = true;
            else
                _deleteCategoryButton.Enabled = false;
        }

        //當修改meal textbox內容
        private void OnMealTextBoxChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Modified)
                _saveButton1.Enabled = CheckMealInput();          
        }

        //當修改meal combobox內容
        private void OnMealComboBoxChanged(object sender, EventArgs e)
        {
            if (_mealListBox.SelectedItem == null)
                return;
            Meal meal = _model.FindMealByName(_mealListBox.SelectedItem.ToString());
            if (((ComboBox)sender).SelectedItem.ToString() != meal.Category.Name)
                _saveButton1.Enabled = CheckMealInput();
        }

        //當修改category textbox內容
        private void OnCategoryTextBoxChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Modified)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                    _saveButton2.Enabled = false;
                else
                    _saveButton2.Enabled = true;
            }                       
        }

        //檢查 meal 欄位都有填
        private bool CheckMealInput()
        {
            if (string.IsNullOrWhiteSpace(_mealImageTextBox.Text))
                return false;
            else if (string.IsNullOrWhiteSpace(_mealNameTextBox.Text))
                return false;
            else if (string.IsNullOrWhiteSpace(_mealPriceTextBox.Text))
                return false;
            else if (string.IsNullOrWhiteSpace(_mealCategoryComboBox.Text))
                return false;
            else
                return true;
        }

        //按下 meal save 按鈕
        private void ClickMealSaveButton(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            string mealName = _mealListBox.SelectedItem.ToString();
            _model.ChangeMealPrice(mealName, _mealPriceTextBox.Text);
            _model.ChangeMealCategory(mealName, _mealCategoryComboBox.SelectedItem.ToString());
            _model.ChangeMealDescription(mealName, _mealDescriptionTextBox.Text);
            _model.ChangeMealImagePath(mealName, _mealImageTextBox.Text);
            _model.ChangeMealName(mealName, _mealNameTextBox.Text);
            UpdateMealListBox();
            _mealListBox.SelectedItem = _mealNameTextBox.Text;
        }

        //按下 Category save 按鈕
        private void ClickCategorySaveButton(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            string categoryOldName = _categoryListBox.SelectedItem.ToString();
            _model.ChangeCategoryName(categoryOldName, _categoryNameTextBox.Text);
            UpdateCategoryListBox();
            _categoryListBox.SelectedItem = _categoryNameTextBox.Text;
        }

        //按下 Browse 按鈕
        private void ClickBrowseButton(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] imageAbosolutePath = _openFileDialog.FileName.Split(SLASH);
                string imageRelativePath = SLASH + imageAbosolutePath[imageAbosolutePath.Length - 2] + SLASH + imageAbosolutePath.Last();
                _mealImageTextBox.Text = imageRelativePath;
                _saveButton1.Enabled = true;
            }
        }

        //按下 delete meal 按鈕
        private void ClickDeleteMealButton(object sender, EventArgs e)
        {
            _model.DeleteMeal(_mealListBox.SelectedItem.ToString());
            _deleteMealButton.Enabled = false;
            _mealDescriptionTextBox.Text = "";
            _mealImageTextBox.Text = "";
            _mealNameTextBox.Text = "";
            _mealPriceTextBox.Text = "";
            _mealCategoryComboBox.Text = "";
        }

        //按下 delete category 按鈕
        private void ClickDeleteCategoryButton(object sender, EventArgs e)
        {
            _model.DeleteCategory(_categoryListBox.SelectedItem.ToString());
        }

        //按下 Add Meal Mode Button
        private void ClickAddMealModeButton(object sender, EventArgs e)
        {
            _saveButton1.Click -= ClickMealSaveButton;
            _saveButton1.Click += ClickAddMealButton;
            _saveButton1.Text = ADD;
            _mealDescriptionTextBox.Text = "";
            _mealImageTextBox.Text = "";
            _mealNameTextBox.Text = "";
            _mealPriceTextBox.Text = "";
            _mealCategoryComboBox.Text = "";
            _mealListBox.Enabled = false;
            _browseButton.Enabled = true;
        }

        //按下 Add Meal Button
        private void ClickAddMealButton(object sender, EventArgs e)
        {
            _model.AddNewMealToMenu(_mealNameTextBox.Text, _mealPriceTextBox.Text, _mealImageTextBox.Text, _mealDescriptionTextBox.Text, _mealCategoryComboBox.SelectedItem.ToString());
            _saveButton1.Click -= ClickAddMealButton;
            _saveButton1.Click += ClickMealSaveButton;
            _saveButton1.Text = SAVE;
            _mealListBox.Enabled = true;
            _mealListBox.SelectedIndex = _mealListBox.Items.Count - 1;
            _deleteMealButton.Enabled = true;
        }

        //按下 Add Category Mode Button
        private void ClickAddCategoryModeButton(object sender, EventArgs e)
        {
            _saveButton2.Click -= ClickCategorySaveButton;
            _saveButton2.Click += ClickAddCategoryButton;
            _saveButton2.Text = ADD;
        }

        //按下 Add Category Button
        private void ClickAddCategoryButton(object sender, EventArgs e)
        {
            _saveButton2.Click += ClickCategorySaveButton;
            _saveButton2.Click -= ClickAddCategoryButton;
            _saveButton2.Text = SAVE;
            _saveButton2.Enabled = false;
            _model.AddNewCategory(_categoryNameTextBox.Text);
        }
    }
}
