using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide
{
    public class Model
    {
        private Order _order = new Order();
        public event MenuChangedEventHandler MenuChanged;
        public delegate void MenuChangedEventHandler();
        public event CategoryChangedEventHandler CategoryChanged;
        public delegate void CategoryChangedEventHandler();

        //更改menu meal name
        public void ChangeMealName(string mealOldName, string mealNewName)
        {
            _order.FindMealByName(mealOldName).Name = mealNewName;
            NotifyMenuChangedObserver();
        }

        //更改menu meal price
        public void ChangeMealPrice(string mealOldName, string mealPrice)
        {
            _order.FindMealByName(mealOldName).Price = Int32.Parse(mealPrice);
            //NotifyMenuChangedObserver();
        }

        //更改menu meal category
        public void ChangeMealCategory(string mealOldName, string categoryName)
        {
            _order.FindMealByName(mealOldName).Category = _order.FindCategory(categoryName);
            NotifyCategoryChangedObserver();
            //NotifyMenuChangedObserver();
        }

        //更改menu meal description
        public void ChangeMealDescription(string mealOldName, string mealDescription)
        {
            _order.FindMealByName(mealOldName).Description = mealDescription;
            //NotifyMenuChangedObserver();
        }

        //更改menu meal image path
        public void ChangeMealImagePath(string mealOldName, string mealImagePath)
        {
            _order.FindMealByName(mealOldName).ImageRelativePath = mealImagePath;
            //NotifyMenuChangedObserver();
        }

        //新增新的餐點到菜單
        public void AddNewMealToMenu(Meal meal)
        {
            _order.AddNewMealToMenu(meal);
            NotifyMenuChangedObserver();
        }

        //刪除指定的餐點
        public void DeleteMeal(string mealName)
        {
            _order.DeleteMeal(mealName);
            NotifyMenuChangedObserver();
        }

        //更改 category 名字
        public void ChangeCategoryName(string categoryOldName, string categoryNewName)
        {
            _order.ChangeCategoryName(categoryOldName, categoryNewName);
            NotifyCategoryChangedObserver();
        }

        //新增新的 category
        public void AddNewCategory(string categoryName)
        {
            _order.AddNewCategory(categoryName);
            NotifyCategoryChangedObserver();
        }

        //刪除指定的 category
        public void DeleteCategory(string categoryName)
        {
            _order.DeleteCategory(categoryName);
            NotifyCategoryChangedObserver();
        }

        //呼叫order中的GetMealList
        public List<Meal> GetMealList()
        {
            return _order.GetMealList();
        }

        //呼叫order中的AddMeal
        public void AddMeal(Meal meal)
        {
            _order.AddMealToMealList(meal);
        }

        //呼叫order中的GetImagePath
        public string GetImagePath(int buttonIndex)
        {
            return _order.GetImagePath(buttonIndex);
        }

        //呼叫order中的GetPrice
        public string GetPrice(int buttonIndex)
        {
            return _order.GetPrice(buttonIndex);
        }

        //呼叫order中的FindMealByName
        public Meal FindMealByName(string mealName)
        {
            return _order.FindMealByName(mealName);
        }

        //呼叫order中的GetDescriptionByName
        public string GetDescriptionByName(string mealName)
        {
            return _order.GetDescriptionByName(mealName);
        }

        //呼叫order中的GetDescriptionByIndex
        public string GetDescriptionByIndex(int mealIndex)
        {
            return _order.GetDescriptionByIndex(mealIndex);
        }

        //呼叫order中的GetTotalPrice
        public int GetTotalPrice()
        {
            return _order.GetTotalPrice();
        }

        //呼叫order中的ClearMealList
        public void ClearMealList()
        {
            _order.ClearMealList();
        }

        //呼叫order中的AddToDisplayMealList
        public void AddToDisplayMealList()
        {
            _order.AddToDisplayMealList();
        }

        //呼叫order中的DeleteFromDisplayMealList
        public void DeleteFromDisplayMealList(string mealName)
        {
            _order.DeleteFromDisplayMealList(mealName);
        }

        //呼叫 order 中的 GetLengthOfMealList
        public int GetLengthOfMealList()
        {
            return _order.GetLengthOfMealList();
        }

        //呼叫 order 中的 GetCategories
        public List<string> GetCategories()
        {
            return _order.GetCategories();
        }

        //呼叫 order 中的 GetMenu
        public List<Meal> GetMenu()
        {
            return _order.GetMenu();
        }

        //呼叫 order 中的 FindCategory
        public Category FindCategory(string categoryName)
        {
            return _order.FindCategory(categoryName);
        }

        //確認 mealList 是不是空的
        public bool IsMealListEmpty()
        {
            if (_order.GetMealList().Count == 0)
                return true;
            else
                return false;
        }

        //通知menu改了
        public void NotifyMenuChangedObserver()
        {
            if (MenuChanged != null)
            {
                MenuChanged();
                Console.WriteLine("Menu Changed");
            }             
        }

        //通知Category改了
        public void NotifyCategoryChangedObserver()
        {
            if (CategoryChanged != null)
            {
                CategoryChanged();
                Console.WriteLine("Category Changed");
            }
        }
    }
}
