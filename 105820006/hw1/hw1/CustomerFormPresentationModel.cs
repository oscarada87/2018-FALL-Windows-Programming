using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide
{
    public class CustomerFormPresentationModel
    {
        public event MenuChangedPresentationEventHandler _menuChangedCustomer;
        public delegate void MenuChangedPresentationEventHandler();
        public event CategoryChangedPresentationEventHandler _categoryChangedCustomer;
        public delegate void CategoryChangedPresentationEventHandler();
        private Model _model;
        private const int BUTTON_LOCATION_X = 10;
        private const int BUTTON_LOCATION_Y = 10;
        private const int ONE_PAGE_BUTTON_NUMBER = 9;
        private const int ROW_BUTTON_NUMBER = 3;
        private const int POSITION_DISTANCE = 160;
        private const string ERROR = "ERROR";
        private const string PAGE = "Page: ";
        private const string SLASH = "/";
        private List<CategoryState> _categoriesState = new List<CategoryState>();

        //Constructor
        public CustomerFormPresentationModel(Model model)
        {
            this._model = model;
            InitialCategoriesState();
            _model._menuChanged += NotifyMenuChangedObserver;
            _model._categoryChanged += NotifyCategoryChangedObserver;
        }

        //初始化category數量
        private void InitialCategoriesState()
        {
            _categoriesState.Clear();
            List<string> categoriesName = _model.GetCategories();
            categoriesName.ForEach(x =>
            {
                _categoriesState.Add(new CategoryState(x));
            });
        }

        //取得button的位置，並將按鈕數量+1
        public List<int> GetMealButtonLocation(int number)
        {
            int locationX = 0;
            int locationY = 0;
            if (number >= ONE_PAGE_BUTTON_NUMBER)
                number = number % ONE_PAGE_BUTTON_NUMBER;
            locationX = (number % ROW_BUTTON_NUMBER) * POSITION_DISTANCE + BUTTON_LOCATION_X;
            locationY = (number / ROW_BUTTON_NUMBER) * POSITION_DISTANCE + BUTTON_LOCATION_Y;
            return new List<int>
            {
                locationX,
                locationY
            };
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
                    if (categoryState.CurrentPage * ONE_PAGE_BUTTON_NUMBER > number && (categoryState.CurrentPage - 1) * ONE_PAGE_BUTTON_NUMBER <= number)
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

        //確認 Add Button 的狀態
        public bool IsAddButtonEnable()
        {
            return !_model.IsMealListEmpty();
        }

        //回傳現在的頁碼
        public string GetCurrentPage(string categoryName)
        {
            foreach (CategoryState category in _categoriesState)
            {
                if (categoryName == category.Name)
                {
                    return PAGE + category.CurrentPage.ToString() + SLASH + category.TotalPage.ToString();
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
        public void RemoveOnePage(string categoryName)
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

        //呼叫model的GetDisplayMealList
        public List<Meal> GetDisplayMealList()
        {
            return _model.GetDisplayMealList();
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
        public void DeleteFromDisplayMealList(string mealName)
        {
            _model.DeleteFromDisplayMealList(mealName);
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

        //通知menu改變
        public void NotifyMenuChangedObserver()
        {
            if (_menuChangedCustomer != null)
            {
                _menuChangedCustomer();
            }           
        }

        //通知 Category 改變
        public void NotifyCategoryChangedObserver()
        {
            if (_categoryChangedCustomer != null)
            {
                _categoryChangedCustomer();
            }
        }
    }
}
