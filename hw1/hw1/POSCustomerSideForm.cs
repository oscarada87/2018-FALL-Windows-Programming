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
        string _projectPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

        public CustomerSideForm(CustomerFormPresentationModel model)
        {
            InitializeComponent();
            this._model = model;
            this._mealGridView.CellClick += ClickDataGridCell;
            this._tabControlButton.SelectedIndexChanged += ClickTabPage;
            UpdateTabPage();
            UpdateMealButton();
        }

        //把category加到tabpage
        private void UpdateTabPage()
        {
            List<string> categoriesName = _model.GetCategories();
            categoriesName.ForEach(x => 
            {
                TabPage tabPage = new TabPage();
                tabPage.Name = x;
                tabPage.Text = x;
                _tabControlButton.TabPages.Add(tabPage);
            });
        }

        //將餐點按鈕加進List中
        private void UpdateMealButton()
        {
            List<Meal> menu = _model.GetMenu();
            menu.ForEach(x =>
            {
                Button button = new Button();
                button.Size = new Size(150, 130);
                button.Location = _model.GetMealButtonLocation(x);
                button.Text = x.Name + "\n" + x.Price.ToString() + DOLLAR;
                button.Font = new Font("微軟正黑體", 10);
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.BackgroundImage = Image.FromFile(_projectPath + x.ImageRelativePath);
                button.ForeColor = Color.White;
                button.TextAlign = ContentAlignment.BottomRight;
                //button.Visible = _model.GetMealButtonVisible(x);
                _mealButtons.Add(button);
                _tabControlButton.TabPages[_model.GetMealButtonCategoryIndex(x)].Controls.Add(button);
            });
            
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
                row.Cells[2].Value = x.Category.Name;
                row.Cells[3].Value = x.Price;
                _mealGridView.Rows.Add(row);
            });
            _model.AddToDisplayMealList();
            _model.ClearMealList();
            UpdateTotalPrice();
        }

        //按下上一頁
        private void ClickPreviousPage(object sender, EventArgs e)
        {
            string categoryName = _tabControlButton.SelectedTab.Name;
            //Console.WriteLine(categoryName);
            for (int i = ZERO; i < NINE; i++)
                _mealButtons[i].Visible = true;
            for (int i = NINE; i < FIFTEEN; i++)
                _mealButtons[i].Visible = false;
            _model.MinusOnePage(categoryName);
            _nextPageButton.Enabled = _model.IsNextPageButtonEnable(categoryName);
            _previousPageButton.Enabled = _model.IsPreviousPageButtonEnable(categoryName);
            _pageLabel1.Text = _model.GetCurrentPage(categoryName);
        }

        //按下下一頁
        private void ClickNextPage(object sender, EventArgs e)
        {
            string categoryName = _tabControlButton.SelectedTab.Name;
            //Console.WriteLine(categoryName);
            for (int i = ZERO; i < NINE; i++)
                _mealButtons[i].Visible = false;
            for (int i = NINE; i < FIFTEEN; i++)
                _mealButtons[i].Visible = true;
            _model.AddOnePage(categoryName);
            _nextPageButton.Enabled = _model.IsNextPageButtonEnable(categoryName);
            _previousPageButton.Enabled = _model.IsPreviousPageButtonEnable(categoryName);
            _pageLabel1.Text = _model.GetCurrentPage(categoryName);
        }

        //按下tabPage
        private void ClickTabPage(object sender, EventArgs e)
        {
            string categoryName = _tabControlButton.SelectedTab.Name;
            //Console.WriteLine(categoryName);
            _nextPageButton.Enabled = _model.IsNextPageButtonEnable(categoryName);
            _previousPageButton.Enabled = _model.IsPreviousPageButtonEnable(categoryName);
            _pageLabel1.Text = _model.GetCurrentPage(categoryName);
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
