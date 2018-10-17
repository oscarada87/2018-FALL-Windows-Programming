using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide
{
    public class RestaurantSidePresentationModel
    {
        private Model _model;

        //Constructor
        public RestaurantSidePresentationModel(Model model)
        {
            this._model = model;
        }

        //呼叫 model 中的 GetMenu
        public List<Meal> GetMenu()
        {
            return _model.GetMenu();
        }

        //呼叫 model 中的 GetCategories
        public List<string> GetCategories()
        {
            return _model.GetCategories();
        }

        //呼叫 model 中的 FindMealByName
        public Meal FindMealByName(string mealName)
        {
            return _model.FindMealByName(mealName);
        }

        //取得在此類別中的所有餐點
        public List<string> GetMealsInCategory(string categoryName)
        {
            List<string> meals = new List<string>();
            _model.GetMenu().ForEach(x =>
            {
                if (x.Category.Name == categoryName)
                    meals.Add(x.Name);
            });
            return meals;
        }
    }
}
