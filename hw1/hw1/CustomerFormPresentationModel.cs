using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace POSCustomerSide
{
    public class CustomerFormPresentationModel
    {
        private POSCustomerSideModel _model = new POSCustomerSideModel();
        private int _currentPage = 1;
        private const int TOTAL_PAGE = 2;
        private const int BUTTONLOCATIONX = 20;
        private const int BUTTONLOCATIONY = 40;
        private List<CategoryState> _categoriesState = new List<CategoryState>();

        //Constructor
        public CustomerFormPresentationModel()
        {
            InitCategoriesState();
        }

        //儲存category狀態的class
        private class CategoryState
        {
            private int _buttonCount;
            private int _currentPage;
            private int _totalPage;
            private string _name;

            public CategoryState(string name)
            {
                this._name = name;
                this._currentPage = 1;
                this._buttonCount = 0;
            }
            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = Name;
                }
            }
            public int CurrentPage
            {
                get
                {
                    return _currentPage;
                }
                set
                {
                    _currentPage = CurrentPage;
                }
            }
            public int TotalPage
            {
                get
                {
                    return _totalPage;
                }
                set
                {
                    _totalPage = TotalPage;
                }
            }
            public int ButtonCount
            {
                get
                {
                    return _buttonCount;
                }
                set
                {
                    _buttonCount = ButtonCount;
                }
            }

            //新增一個按鈕
            public void AddButtonCount()
            {
                _buttonCount = _buttonCount + 1;
            }
        }

        //初始化category數量
        private void InitCategoriesState()
        {
            _categoriesState.Clear();
            List<string> categoriesName =  _model.GetCategories();
            categoriesName.ForEach(x =>
            {
                _categoriesState.Add(new CategoryState(x));
            });
        }

        //取得button的位置，並將按鈕數量+1
        public Point GetMealButtonLocation(Meal meal)
        {
            int XLocation = 0;
            int YLocation = 0;
            _categoriesState.ForEach(x =>
            {
                if (meal.Category.Name == x.Name)
                {
                    int buttonCount = 0;
                    if (x.ButtonCount > 9)
                    {
                        buttonCount = x.ButtonCount % 9;
                    }
                    XLocation = (buttonCount / 3) * 160 + BUTTONLOCATIONX;
                    YLocation = (buttonCount % 3) * 160 + BUTTONLOCATIONY;
                    x.AddButtonCount();
                }
            });
            //Console.WriteLine(meal.Name + "\n X:" + XLocation + "\n Y:" + YLocation);
            return new Point(XLocation, YLocation);
        }

        //取得button的category的index
        public int GetMealButtonCategoryIndex(Meal meal)
        {
            int index = 0;
            _categoriesState.ForEach(x =>
            {
                if (meal.Category.Name == x.Name)
                {
                    index = _categoriesState.IndexOf(x);
                }
            });
            return index;
        }

        //取得button的visible
        public bool GetMealButtonVisible(Meal meal)
        {
            bool visible = true;
            _categoriesState.ForEach(x =>
            {
                if (meal.Category.Name == x.Name)
                {
                    if (x.ButtonCount > 9)
                        visible = false;
                }
            });
            return visible;
        }

        //確認Next Page的狀態
        public bool IsNextPageButtonEnable()
        {
            if (_currentPage == TOTAL_PAGE)
                return false;
            else
                return true;
        }

        //確認Previous Page的狀態
        public bool IsPreviousPageButtonEnable()
        {
            if (_currentPage == 1)
                return false;
            else
                return true;
        }

        //回傳現在的頁碼
        public string GetCurrentPage()
        {
            String currentPage = "Page: " + _currentPage.ToString() + "/2";
            return currentPage;
        }

        //加1頁
        public void AddOnePage()
        {
            _currentPage++;
        }

        //減1頁
        public void MinusOnePage()
        {
            _currentPage--;
        }

        //呼叫model的GetMealList
        public List<Meal> GetMealList()
        {
            return _model.GetMealList();
        }

        //呼叫model中的AddMeal
        public void AddMeal(int buttonNumber)
        {
            _model.AddMeal(buttonNumber);
        }

        //呼叫model中的AddToDisplayMealList
        public void AddToDisplayMealList()
        {
            _model.AddToDisplayMealList();
        }

        //呼叫model中的DeleteFromDisplayMealList
        public void DeleteFromDisplayMealList(int mealIndex)
        {
            _model.DeleteFromDisplayMealList(mealIndex);
        }

        //呼叫model中的ClearMealList
        public void ClearMealList()
        {
            _model.ClearMealList();
        }

        //呼叫model中的GetTotalPrice
        public int GetTotalPrice()
        {
            return _model.GetTotalPrice();
        }

        //呼叫model中的GetImagePath
        public string GetImagePath(int buttonIndex)
        {
            return _model.GetImagePath(buttonIndex);
        }

        //呼叫model中的GetPrice
        public string GetPrice(int buttonIndex)
        {
            return _model.GetPrice(buttonIndex);
        }

        //呼叫model中的GetDescriptionByName
        public string GetDescriptionByName(string mealName)
        {
            return _model.GetDescriptionByName(mealName);
        }

        //呼叫model中的GetDescriptionByIndex
        public string GetDescriptionByIndex(int mealIndex)
        {
            return _model.GetDescriptionByIndex(mealIndex);
        }

        //呼叫model中的GetCategories
        public List<string> GetCategories()
        {
            return _model.GetCategories();
        }

        //呼叫model中的GetMenu
        public List<Meal> GetMenu()
        {
            return _model.GetMenu();
        }
    }
}
