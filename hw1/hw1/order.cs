using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide
{
    public class Order
    {
        private List<Meal> _mealList = new List<Meal>();
        private List<Meal> _displayMealList = new List<Meal>();
        //新增一項餐點
        public void AddMeal(string name, int price)
        {
            Meal meal = new Meal(name, price);
            _mealList.Add(meal);
        }

        //清除要新增的餐點列表
        public void ClearMealList()
        {
            _mealList.Clear();
        }

        //取得要新增的餐點列表
        public List<Meal> GetMealList()
        {
            return _mealList;
        }

        //取得要新增的餐點數量
        public int GetLengthOfMealList()
        {
            return _mealList.Count;
        }

        //將要新增的餐點加進display中
        public void AddToDisplayMealList()
        {
            _displayMealList.AddRange(_mealList);
        }

        //取得總價
        public int GetTotalPrice()
        {
            int total = _displayMealList.Sum(x => x.Price);
            return total;
        }
    }
}
