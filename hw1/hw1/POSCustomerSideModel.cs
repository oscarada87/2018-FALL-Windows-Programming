using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide
{
    public class POSCustomerSideModel
    {
        private Order _order = new Order();

        //呼叫order中的GetMealList
        public List<Meal> GetMealList()
        {
            return _order.GetMealList();
        }

        //呼叫order中的AddMeal
        public void AddMeal(int buttonNumber)
        {
            _order.AddMeal(buttonNumber);
        }

        //處理按鈕傳過來的字串
        public string[] ProcessInput(string input)
        {
            string [] result = input.Split('\n');
            result[1] = result[1].Trim(new char[] {'$','元'});
            return result;
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

        //呼叫order中的GetLengthOfMealList
        public int GetLengthOfMealList()
        {
            return _order.GetLengthOfMealList();
        }
    }
}
