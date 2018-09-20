using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
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
        public void AddMeal(string name, int price)
        {
            _order.AddMeal(name, price);
        }

        //呼叫order中的GetTotalPrice
        public int GetTotalPrice()
        {
            return _order.GetTotalPrice();
        }

        //呼叫order中的GetLengthOfMealList
        public int GetLengthOfMealList()
        {
            return _order.GetLengthOfMealList();
        }
    }
}
