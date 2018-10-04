using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POSCustomerSide
{
    public partial class CustomerSideForm : Form
    {
        string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        const string IMAGE_RELATIVE_PATH = @"\resources\";
        const string IMAGE_FILE_NAME = ".jpg";
        const int ZERO = 0;
        const int NINE = 9;
        const int FIFTEEN = 15; 
        //private POSCustomerSideModel _model;
        private CustomerFormPresentationModel _model;

        public CustomerSideForm(CustomerFormPresentationModel model)
        {
            InitializeComponent();
            this._model = model;
            this._mealGridView.CellClick += ClickDataGridCell;
            this.AddBackGroundImageToMealButton();
        }

        //加入背景圖片到按鈕
        private void AddBackGroundImageToMealButton()
        {
            for (int i = 1; i < 16; i++)
            {
                _mealsGroupBox.Controls[i - 1].BackgroundImage = Image.FromFile(projectPath + IMAGE_RELATIVE_PATH + i.ToString() + IMAGE_FILE_NAME);
                _mealsGroupBox.Controls[i - 1].BackgroundImageLayout = ImageLayout.Stretch;
            }
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
                row.Cells[0].Value = "X";
                row.Cells[1].Value = x.Name;
                row.Cells[2].Value = x.Price;
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
            _model.MinusOnePage();
            _nextPageButton.Enabled = _model.IsNextPageButtonEnable();
            _previousPageButton.Enabled = _model.IsPreviousPageButtonEnable();
            _pageLabel1.Text = _model.GetCurrentPage();
        }

        //按下下一頁
        private void ClickNextPage(object sender, EventArgs e)
        {
            for (int i = ZERO; i < NINE; i++)
                _mealsGroupBox.Controls[i].Visible = false;
            for (int i = NINE; i < FIFTEEN; i++)
                _mealsGroupBox.Controls[i].Visible = true;
            _model.AddOnePage();
            _nextPageButton.Enabled = _model.IsNextPageButtonEnable();
            _previousPageButton.Enabled = _model.IsPreviousPageButtonEnable();
            _pageLabel1.Text = _model.GetCurrentPage();
        }

        //按下datagridview中的刪除鈕
        private void ClickDataGridCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == _mealGridView.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == _mealGridView.Columns["_deleteColumn"].Index)
            {
                _mealGridView.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
