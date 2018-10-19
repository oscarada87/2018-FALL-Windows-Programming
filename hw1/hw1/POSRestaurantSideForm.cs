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

        public RestaurantSideForm(RestaurantSidePresentationModel model)
        {
            this._model = model;
            InitializeComponent();
            _mealListBox.Click += ClickMealListBox;
            _categoryListBox.Click += ClickCategoryListBox;
            _mealDescriptionTextBox.TextChanged += OnMealTextBoxChanged;
            _mealImageTextBox.TextChanged += OnMealTextBoxChanged;
            _mealNameTextBox.TextChanged += OnMealTextBoxChanged;
            _mealPriceTextBox.TextChanged += OnMealTextBoxChanged;
            _mealCategoryComboBox.TextChanged += OnMealComboBoxChanged;
            _categoryNameTextBox.TextChanged += OnCategoryTextBoxChanged;
            _saveButton1.Click += ClickMealSaveButton;
            UpdateMealListBox();
            UpdateCategoryBox();
            _model.MenuChanged += UpdateMealListBox;
            _model.MenuChanged += UpdateCategoryBox;
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
        private void UpdateCategoryBox()
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
        }

        //當修改meal textbox內容
        private void OnMealTextBoxChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
                _saveButton1.Enabled = true;
        }

        //當修改meal combobox內容
        private void OnMealComboBoxChanged(object sender, EventArgs e)
        {
            Meal meal = _model.FindMealByName(_mealListBox.SelectedItem.ToString());
            if (((ComboBox)sender).SelectedItem.ToString() != meal.Category.Name)
                _saveButton1.Enabled = true;
        }

        //當修改category textbox內容
        private void OnCategoryTextBoxChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Modified)
                _saveButton2.Enabled = true;
        }

        //按下save按鈕
        private void ClickMealSaveButton(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            string mealName = _mealListBox.SelectedItem.ToString();
            _model.ChangeMealName(mealName, _mealNameTextBox.Text);
            _model.ChangeMealPrice(mealName, _mealPriceTextBox.Text);
            _model.ChangeMealCategory(mealName, _mealCategoryComboBox.SelectedItem.ToString());
            _model.ChangeMealDescription(mealName, _mealDescriptionTextBox.Text);
            _model.ChangeMealImagePath(mealName, _mealImageTextBox.Text);
            UpdateMealListBox();
            _mealListBox.SelectedItem = _mealNameTextBox.Text;
        }
    }
}
