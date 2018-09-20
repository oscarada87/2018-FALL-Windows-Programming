using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    public class Order
    {
        private List<Meal> _mealList = new List<Meal>();

        //新增一項餐點
        public void AddMeal(string name, int price)
        {
            Meal meal = new Meal(name, price);
            _mealList.Add(meal);
        }

        //清除餐點列表
        public void ClearMealList()
        {
            _mealList.Clear();
        }

        //取得餐點列表
        public List<Meal> GetMealList()
        {
            return _mealList;
        }

        //取得餐點數量
        public int GetLengthOfMealList()
        {
            return _mealList.Count;
        }

        //取得總價
        public int GetTotalPrice()
        {
            int total = _mealList.Sum(x => x.GetPrice());
            return total;
        }
    }
}
