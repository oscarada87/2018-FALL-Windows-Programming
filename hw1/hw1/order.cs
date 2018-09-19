using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Order
    {
        private List<Meal> _mealList = new List<Meal>();
        //新增一項餐點
        public void AddMeal(string name, int price)
        {
            Meal meal = new Meal(name, price);
            _mealList.Add(meal);
        }
        //取得餐點列表
        public List<Meal> GetMealList()
        {
            return _mealList;
        }
    }
}
