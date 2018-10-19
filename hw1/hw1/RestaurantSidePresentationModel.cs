﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide
{
    public class RestaurantSidePresentationModel
    {
        private Model _model;
        public event MenuChangedRestaurantEventHandler MenuChangedRestaurant;
        public delegate void MenuChangedRestaurantEventHandler();

        //Constructor
        public RestaurantSidePresentationModel(Model model)
        {
            this._model = model;
            _model.MenuChanged += NotifyMenuChangedObserver;
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

        //呼叫 model 中的 FindMealCategory
        public Category FindMealCategory(string categoryName)
        {
            return _model.FindMealCategory(categoryName);
        }

        //呼叫 model 中的 ChangeMealName
        public void ChangeMealName(string mealOldName, string mealNewName)
        {
            _model.ChangeMealName(mealOldName, mealNewName);
        }

        //呼叫 model 中的 ChangeMealPrice
        public void ChangeMealPrice(string mealOldName, string mealPrice)
        {
            _model.ChangeMealPrice(mealOldName, mealPrice);
        }

        //呼叫 model 中的 ChangeMealCategory
        public void ChangeMealCategory(string mealOldName, string categoryName)
        {
            _model.ChangeMealCategory(mealOldName, categoryName);
        }

        //呼叫 model 中的 ChangeMealDescription
        public void ChangeMealDescription(string mealOldName, string mealDescription)
        {
            _model.ChangeMealDescription(mealOldName, mealDescription);
        }

        //呼叫 model 中的 ChangeMealImagePath
        public void ChangeMealImagePath(string mealOldName, string mealImagePath)
        {
            _model.ChangeMealImagePath(mealOldName, mealImagePath);
        }

        //呼叫 model 中的 ChangeCategoryName
        public void ChangeCategoryName(string categoryOldName, string categoryNewName)
        {
            _model.ChangeCategoryName(categoryOldName, categoryNewName);
        }

        //呼叫 model 中的 AddNewCategory
        public void AddNewCategory(string categoryName)
        {
            _model.AddNewCategory(categoryName);
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
        
        //通知menu改變
        public void NotifyMenuChangedObserver()
        {
            if (MenuChangedRestaurant != null)
            {
                MenuChangedRestaurant();
                Console.WriteLine("RP Model Notify");
            }
        }
    }
}
