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
    public partial class CustomerSideForm : Form
    {
        const int ZERO = 0;
        const int NINE = 9;
        const int FIFTEEN = 15; 
        private POSCustomerSideModel _model = new POSCustomerSideModel();

        public CustomerSideForm(POSCustomerSideModel _model)
        {
            InitializeComponent();
        }

        //按下食物按鈕
        private void MealButtonClick(object sender, EventArgs e)
        {
            Button mealButton = (Button)sender;
            _model.AddMeal(mealButton.Text);
        }

        //按下新增按鈕
        private void AddButtonClick(object sender, EventArgs e)
        {
            List<Meal> mealList = _model.GetMealList();

            mealList.ForEach(x =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(_mealGridView);
                row.Cells[0].Value = x.Name;
                row.Cells[1].Value = x.Price;
                _mealGridView.Rows.Add(row);
            });
            _model.AddToDisplayMealList();
            _model.ClearMealList();
            _totalLabel.Text = "Total: " + _model.GetTotalPrice() + "元";
        }

        //按下上一頁
        private void ClickPreviousPage(object sender, EventArgs e)
        {
            for (int i = ZERO; i < NINE; i++)
                _mealsGroupBox.Controls[i].Visible = true;
            for (int i = NINE; i < FIFTEEN; i++)
                _mealsGroupBox.Controls[i].Visible = false;
            _nextPageButton.Enabled = true;
            _previousPageButton.Enabled = false;
            _pageLabel1.Text = "Page: 1/2";
        }

        //按下下一頁
        private void ClickNextPage(object sender, EventArgs e)
        {
            for (int i = ZERO; i < NINE; i++)
                _mealsGroupBox.Controls[i].Visible = false;
            for (int i = NINE; i < FIFTEEN; i++)
                _mealsGroupBox.Controls[i].Visible = true;
            _nextPageButton.Enabled = false;
            _previousPageButton.Enabled = true;
            _pageLabel1.Text = "Page: 2/2";
        }
    }
}
