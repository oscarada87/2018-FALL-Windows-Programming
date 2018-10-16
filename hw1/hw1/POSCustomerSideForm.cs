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
        private const string DOLLAR = "元"; 
        private CustomerFormPresentationModel _model;
        private List<List<Button>> _mealButtons = new List<List<Button>>();
        string _projectPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

        public CustomerSideForm(CustomerFormPresentationModel model)
        {
            InitializeComponent();
            this._model = model;
            this._mealGridView.CellClick += ClickDataGridCell;
            this._tabControlButton.SelectedIndexChanged += ClickTabPage;
            InitButtonList();
            UpdateTabPage();
            UpdateMealButton();
            UpdateTotalPage();
        }

        //初始化按鈕類別
        public void InitButtonList()
        {
            for (int i = ZERO; i < _model.GetCategories().Count; i++)
                _mealButtons.Add(new List<Button>());
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
            List<string> categories = _model.GetCategories();
            menu.ForEach(x =>
            {
                Button button = new Button();
                button.Size = new Size(150, 130);
                button.Text = x.Name + "\n" + x.Price.ToString() + DOLLAR;
                button.Font = new Font("微軟正黑體", 10, FontStyle.Bold);
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.BackgroundImage = Image.FromFile(_projectPath + x.ImageRelativePath);
                button.ForeColor = Color.Red;
                button.TextAlign = ContentAlignment.BottomRight;
                button.Click += MealButtonClick;
                UpdateMealCategory(x.Category.Name, button);
                button.Location = _model.GetMealButtonLocation(_mealButtons[categories.IndexOf(x.Category.Name)].IndexOf(button));
            });
        }

        //將餐點按鈕加到正確的類別
        private void UpdateMealCategory(string category, Button button)
        {
            List<string> categories = _model.GetCategories();
            categories.ForEach(x =>
            {
                if (x == category)
                {
                    _mealButtons[categories.IndexOf(x)].Add(button);
                    _tabControlButton.TabPages[categories.IndexOf(x)].Controls.Add(button);
                    button.Visible = _model.GetMealButtonVisible(x, _mealButtons[categories.IndexOf(x)].IndexOf(button));
                }
            });
        }

        //更新最大頁數
        private void UpdateTotalPage()
        {
            _mealButtons.ForEach(x =>
            {
                _model.UpdateTotalPage(x.Count, _mealButtons.IndexOf(x));
            });
        }

        //按下食物按鈕
        private void MealButtonClick(object sender, EventArgs e)
        {
            Button mealButton = (Button)sender;
            Meal meal = _model.FindMealByName(mealButton.Text.Split('\n')[0]);
            _model.AddMeal(meal);
            //Console.WriteLine(mealButton.Text.Split('\n')[0]);
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
                row.Cells[4].Value = 1;
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
            List<string> categories = _model.GetCategories();
            _model.MinusOnePage(categoryName);
            _nextPageButton.Enabled = _model.IsNextPageButtonEnable(categoryName);
            _previousPageButton.Enabled = _model.IsPreviousPageButtonEnable(categoryName);
            _pageLabel1.Text = _model.GetCurrentPage(categoryName);
            categories.ForEach(x =>
            {
                if (x == categoryName)
                {
                    _mealButtons[categories.IndexOf(x)].ForEach(y =>
                    {
                        y.Visible = _model.GetMealButtonVisible(x, _mealButtons[categories.IndexOf(x)].IndexOf(y));
                    });            
                }
            });
        }

        //按下下一頁
        private void ClickNextPage(object sender, EventArgs e)
        {
            string categoryName = _tabControlButton.SelectedTab.Name;
            List<string> categories = _model.GetCategories();
            _model.AddOnePage(categoryName);
            _nextPageButton.Enabled = _model.IsNextPageButtonEnable(categoryName);
            _previousPageButton.Enabled = _model.IsPreviousPageButtonEnable(categoryName);
            _pageLabel1.Text = _model.GetCurrentPage(categoryName);
            categories.ForEach(x =>
            {
                if (x == categoryName)
                {
                    _mealButtons[categories.IndexOf(x)].ForEach(y =>
                    {
                        y.Visible = _model.GetMealButtonVisible(x, _mealButtons[categories.IndexOf(x)].IndexOf(y));
                    });
                }
            });
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
