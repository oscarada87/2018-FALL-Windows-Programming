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
        private const string X = "X";
        private const string NEW_TAIWAN_DOLLAR = "  NTD";
        private const int TWO = 2;
        private const int THREE = 3;
        private const int FOUR = 4;
        private const int FIVE = 5;
        private CustomerFormPresentationModel _model;
        private List<List<Button>> _mealButtons = new List<List<Button>>();
        string _projectPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

        public CustomerSideForm(CustomerFormPresentationModel model)
        {
            InitializeComponent();
            this._model = model;
            _mealGridView.CellClick += ClickDataGridCell;
            _mealGridView.CellValueChanged += ChangeDataGridViewValue;
            _tabControlButton.SelectedIndexChanged += ClickTabPage;
            UpdateButtonList();
            InitialTabPage();
            UpdateMealButton();
            UpdateTotalPage();
            _model._menuChangedCustomer += ClearButton;
            _model._menuChangedCustomer += UpdateButtonList;
            _model._menuChangedCustomer += UpdateMealButton;
            _model._menuChangedCustomer += UpdateDataGridViewRow;
            _model._categoryChangedCustomer += UpdateTabPage;
            _model._categoryChangedCustomer += UpdateDataGridViewRow;
        }

        //初始化按鈕類別
        public void UpdateButtonList()
        {
            _mealButtons.Clear();
            for (int i = ZERO; i < _model.GetCategories().Count; i++)
                _mealButtons.Add(new List<Button>());
        }

        //把category加到tabpage
        private void InitialTabPage()
        {
            _tabControlButton.TabPages.Clear();
            List<string> categoriesName = _model.GetCategories();
            categoriesName.ForEach(x => 
            {
                TabPage tabPage = new TabPage();
                tabPage.Name = x;
                tabPage.Text = x;
                _tabControlButton.TabPages.Add(tabPage);
            });
        }

        //更新tabpage
        private void UpdateTabPage()
        {
            List<string> categoriesName = _model.GetCategories();
            categoriesName.ForEach(x =>
            {
                if (categoriesName.IndexOf(x) <= _tabControlButton.TabPages.Count - 1)
                {
                    _tabControlButton.TabPages[categoriesName.IndexOf(x)].Text = x;
                    _tabControlButton.TabPages[categoriesName.IndexOf(x)].Name = x;
                }
                else
                {
                    TabPage tabPage = new TabPage();
                    tabPage.Text = x;
                    tabPage.Name = x;
                    _tabControlButton.TabPages.Add(tabPage);
                }

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

        //清空按鈕
        private void ClearButton()
        {
            foreach (TabPage tabPage in _tabControlButton.TabPages)
            {
                tabPage.Controls.Clear();
            }       
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
            _addButton.Enabled = _model.IsAddButtonEnable();
            _mealDescriptionBox.Text = meal.Description;
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
                row.Cells[0].Value = X;
                row.Cells[1].Value = x.Name;
                row.Cells[TWO].Value = x.Category.Name;
                row.Cells[THREE].Value = x.Price;
                row.Cells[FOUR].Value = 1;
                row.Cells[FIVE].Value = x.Price.ToString() + NEW_TAIWAN_DOLLAR;
                _mealGridView.Rows.Add(row);
            });
            _model.AddToDisplayMealList();
            _model.ClearMealList();
            UpdateTotalPrice();
            _addButton.Enabled = _model.IsAddButtonEnable();
        }

        //更新 DataGridView 資料
        private void UpdateDataGridViewRow()
        {
            List<Meal> displayMealList = _model.GetDisplayMealList();
            List<int> quantityList = GetOldQuantity();
            quantityList.ForEach(x =>
            {
                Console.WriteLine(x);
            });
            _mealGridView.Rows.Clear();
            displayMealList.ForEach(x =>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(_mealGridView);
                row.Cells[0].Value = X;
                row.Cells[1].Value = x.Name;
                row.Cells[TWO].Value = x.Category.Name;
                row.Cells[THREE].Value = x.Price;
                if (displayMealList.IndexOf(x) <= quantityList.Count - 1)
                    row.Cells[FOUR].Value = quantityList[displayMealList.IndexOf(x)];
                else
                    row.Cells[FOUR].Value = 1;
                row.Cells[FIVE].Value = (Int32.Parse(x.Price.ToString()) * Int32.Parse(row.Cells[FOUR].Value.ToString())).ToString() + NEW_TAIWAN_DOLLAR;
                _mealGridView.Rows.Add(row);
            });
            UpdateTotalPrice();
        }

        //取得舊的數量
        private List<int> GetOldQuantity()
        {
            List<int> quantityList = new List<int>();
            foreach (DataGridViewRow row in _mealGridView.Rows)
            {
                quantityList.Add(Int32.Parse(row.Cells[FOUR].Value.ToString()));
            }
            return quantityList;
        }

        //按下上一頁
        private void ClickPreviousPage(object sender, EventArgs e)
        {
            string categoryName = _tabControlButton.SelectedTab.Name;
            List<string> categories = _model.GetCategories();
            _model.RemoveOnePage(categoryName);
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
                _model.DeleteFromDisplayMealList(dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                _mealGridView.Rows.RemoveAt(e.RowIndex);
                UpdateTotalPrice();
            }
            else
            {
                _mealDescriptionBox.Text = _model.FindMealByName(dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString()).Description;
            }
        }

        //更改DataGridView內的值
        private void ChangeDataGridViewValue(object sender, DataGridViewCellEventArgs e)
        {
            int number = Int32.Parse(_mealGridView.Rows[e.RowIndex].Cells[FOUR].Value.ToString());
            int subtotal = Int32.Parse(_mealGridView.Rows[e.RowIndex].Cells[THREE].Value.ToString()) * number;
            _mealGridView.Rows[e.RowIndex].Cells[FIVE].Value = subtotal.ToString() + " NTD";
            UpdateTotalPrice();
        }

        //更新總價
        private void UpdateTotalPrice()
        {
            int total = 0;
            foreach (DataGridViewRow row in _mealGridView.Rows)
            {
                string subtotal = (string)row.Cells[FIVE].Value;
                total = total + Int32.Parse(subtotal.Split(' ')[0]);
            }

            //_totalLabel.Text = "Total: " + _model.GetTotalPrice() + DOLLAR;
            _totalLabel.Text = "Total: " + total.ToString() + DOLLAR;
        }
    }
}
