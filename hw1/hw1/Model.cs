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

        //呼叫order中的GetMealList
        public List<Meal> GetMealList()
        {
            return _order.GetMealList();
        }

        //呼叫order中的AddMeal
        public void AddMeal(Meal meal)
        {
            _order.AddMeal(meal);
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
        public void DeleteFromDisplayMealList(int mealIndex)
        {
            _order.DeleteFromDisplayMealList(mealIndex);
        }

        //呼叫order中的GetLengthOfMealList
        public int GetLengthOfMealList()
        {
            return _order.GetLengthOfMealList();
        }

        //呼叫order中的GetCategories
        public List<string> GetCategories()
        {
            return _order.GetCategories();
        }

        //呼叫order中的GetMenu
        public List<Meal> GetMenu()
        {
            return _order.GetMenu();
        }
    }
}
