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
        private const int ZERO = 0;
        private const int NINE = 9;
        private const int FIFTEEN = 15;
        private const string DOLLAR = "元"; 
        private CustomerFormPresentationModel _model;
        private List<Button> _mealButtons = new List<Button>();

        public CustomerSideForm(CustomerFormPresentationModel model)
        {
            InitializeComponent();
            this._model = model;
            this._mealGridView.CellClick += ClickDataGridCell;
            this.AddMealButtonToList();
            this.AddTextToMealButton();
            this.AddBackGroundImageToMealButton();
        }

        //將餐點按鈕加進List中
        private void AddMealButtonToList()
        {
            _mealButtons.Add(_mealButton1);
            _mealButtons.Add(_mealButton2);
            _mealButtons.Add(_mealButton3);
            _mealButtons.Add(_mealButton4);
            _mealButtons.Add(_mealButton5);
            _mealButtons.Add(_mealButton6);
            _mealButtons.Add(_mealButton7);
            _mealButtons.Add(_mealButton8);
            _mealButtons.Add(_mealButton9);
            _mealButtons.Add(_mealButton10);
            _mealButtons.Add(_mealButton11);
            _mealButtons.Add(_mealButton12);
            _mealButtons.Add(_mealButton13);
            _mealButtons.Add(_mealButton14);
            _mealButtons.Add(_mealButton15);
        }

        //加入背景圖片到按鈕
        private void AddBackGroundImageToMealButton()
        {
            foreach (Button mealButton in _mealButtons)
            {
                mealButton.BackgroundImage = Image.FromFile(_model.GetImagePath(_mealButtons.IndexOf(mealButton)));
                mealButton.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        //加入文字到按鈕
        private void AddTextToMealButton()
        {
            foreach (Button mealButton in _mealButtons)
            {
                mealButton.Text = "$ "+_model.GetPrice(_mealButtons.IndexOf(mealButton)) + DOLLAR;
                mealButton.ForeColor = Color.White;
                mealButton.TextAlign = ContentAlignment.BottomRight;
            }
        }

        //按下食物按鈕
        private void MealButtonClick(object sender, EventArgs e)
        {
            Button mealButton = (Button)sender;
            _model.AddMeal(_mealButtons.IndexOf(mealButton));
            _mealDescriptionBox.Text = _model.GetDescriptionByIndex(_mealButtons.IndexOf(mealButton));
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
            UpdateTotalPrice();
        }

        //按下上一頁
        private void ClickPreviousPage(object sender, EventArgs e)
        {
            for (int i = ZERO; i < NINE; i++)
                _mealButtons[i].Visible = true;
            for (int i = NINE; i < FIFTEEN; i++)
                _mealButtons[i].Visible = false;
            _model.MinusOnePage();
            _nextPageButton.Enabled = _model.IsNextPageButtonEnable();
            _previousPageButton.Enabled = _model.IsPreviousPageButtonEnable();
            _pageLabel1.Text = _model.GetCurrentPage();
        }

        //按下下一頁
        private void ClickNextPage(object sender, EventArgs e)
        {
            for (int i = ZERO; i < NINE; i++)
                _mealButtons[i].Visible = false;
            for (int i = NINE; i < FIFTEEN; i++)
                _mealButtons[i].Visible = true;
            _model.AddOnePage();
            _nextPageButton.Enabled = _model.IsNextPageButtonEnable();
            _previousPageButton.Enabled = _model.IsPreviousPageButtonEnable();
            _pageLabel1.Text = _model.GetCurrentPage();
        }

        //按下datagridview中的物件
        private void ClickDataGridCell(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            if (e.RowIndex == _mealGridView.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == _mealGridView.Columns["_deleteColumn"].Index)
            {
                _model.DeleteFromDisplayMealList(e.RowIndex);
                UpdateTotalPrice();
                _mealGridView.Rows.RemoveAt(e.RowIndex);
            }
            else
            {
                _mealDescriptionBox.Text = _model.GetDescriptionByName(dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }

        //更新總價
        private void UpdateTotalPrice()
        {
            _totalLabel.Text = "Total: " + _model.GetTotalPrice() + DOLLAR;
        }
    }
}
