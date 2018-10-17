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
            UpdateMealListBox();
            UpdateCategoryBox();
        }

        //更新餐點
        private void UpdateMealListBox()
        {
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
            Meal selectedMeal = _model.FindMealByName(mealListBox.SelectedItem.ToString());
            _mealNameTextBox.Text = selectedMeal.Name;
            _mealPriceTextBox.Text = selectedMeal.Price.ToString();
            _mealImageTextBox.Text = selectedMeal.ImageRelativePath;
            _mealDesciptionTextBox.Text = selectedMeal.Description;
            _mealCategoryComboBox.SelectedItem = selectedMeal.Category.Name;
        }

        //按下category listbox
        private void ClickCategoryListBox(object sender, EventArgs e)
        {
            _categoryUsingListBox.Items.Clear();
            ListBox categoryListBox = (ListBox)sender;
            _model.GetMealsInCategory(categoryListBox.SelectedItem.ToString()).ForEach(x =>
            {
                _categoryUsingListBox.Items.Add(x);
            });
            _categoryNameTextBox.Text = categoryListBox.SelectedItem.ToString();
        }
    }
}
