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
        private Model _model;
        private const int BUTTONLOCATIONX = 10;
        private const int BUTTONLOCATIONY = 10;
        private const int NUMBEROFONEPAGEBUTTON = 9;
        private const string ERROR = "ERROR";
        private List<CategoryState> _categoriesState = new List<CategoryState>();

        //Constructor
        public CustomerFormPresentationModel(Model model)
        {
            this._model = model;
            InitCategoriesState();

        }

        //儲存category狀態的class
        private class CategoryState
        {
            private int _currentPage;
            private int _totalPage;
            private string _name;

            public CategoryState(string name)
            {
                this._name = name;
                this._currentPage = 1;
                this._totalPage = 1;
            }
            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
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
                    _currentPage = value;
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
                    _totalPage = value;
                }
            }
            //更新最大頁數
            public void UpdateTotalPage(int number)
            {
                _totalPage = (number / NUMBEROFONEPAGEBUTTON) + 1;
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
        public Point GetMealButtonLocation(int number)
        {
            int XLocation = 0;
            int YLocation = 0;
            if (number >= NUMBEROFONEPAGEBUTTON)
                number = number % NUMBEROFONEPAGEBUTTON;
            XLocation = (number % 3) * 160 + BUTTONLOCATIONX;
            YLocation = (number / 3) * 160 + BUTTONLOCATIONY;
            return new Point(XLocation, YLocation);
        }

        //更新最大頁數
        public void UpdateTotalPage(int buttonNumber, int categoryIndex)
        {
            _categoriesState[categoryIndex].UpdateTotalPage(buttonNumber);
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
        public bool GetMealButtonVisible(string tabName, int number)
        {
            foreach (CategoryState categoryState in _categoriesState)
            {
                if (categoryState.Name == tabName)
                {
                    if (categoryState.CurrentPage * NUMBEROFONEPAGEBUTTON > number && (categoryState.CurrentPage - 1) * NUMBEROFONEPAGEBUTTON <= number)
                        return true;
                    else
                        return false;
                }
            };
            Console.WriteLine(ERROR);
            return false;
        }

        //確認Next Page的狀態
        public bool IsNextPageButtonEnable(string categoryName)
        {
            foreach (CategoryState category in _categoriesState )
            {
                if (categoryName == category.Name)
                {
                    if (category.CurrentPage >= category.TotalPage)
                        return false;
                    else
                        return true;
                }
            }
            Console.WriteLine(ERROR);
            return false;
        }

        //確認Previous Page的狀態
        public bool IsPreviousPageButtonEnable(string categoryName)
        {
            foreach (CategoryState category in _categoriesState)
            {
                if (categoryName == category.Name)
                {
                    if (category.CurrentPage == 1)
                        return false;
                    else
                        return true;
                }
            }
            Console.WriteLine(ERROR);
            return false;
        }

        //回傳現在的頁碼
        public string GetCurrentPage(string categoryName)
        {
            foreach (CategoryState category in _categoriesState)
            {
                if (categoryName == category.Name)
                {
                    return "Page: " + category.CurrentPage.ToString() + "/" + category.TotalPage.ToString();
                }
            }
            return "";
        }

        //加1頁
        public void AddOnePage(string categoryName)
        {
            foreach (CategoryState category in _categoriesState)
            {
                if (categoryName == category.Name)
                {
                    category.CurrentPage++;
                }
            }
        }

        //減1頁
        public void MinusOnePage(string categoryName)
        {
            foreach (CategoryState category in _categoriesState)
            {
                if (categoryName == category.Name)
                {
                    category.CurrentPage--;
                }
            }
        }

        //呼叫model的GetMealList
        public List<Meal> GetMealList()
        {
            return _model.GetMealList();
        }

        //呼叫model中的AddMeal
        public void AddMeal(Meal meal)
        {
            _model.AddMeal(meal);
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

        //呼叫model中的FindMealByName
        public Meal FindMealByName(string mealName)
        {
            return _model.FindMealByName(mealName);
        }
    }
}
