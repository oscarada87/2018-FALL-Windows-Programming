﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide
{
    public class CustomerFormPresentationModel
    {
        private POSCustomerSideModel _model = new POSCustomerSideModel();
        private int _currentPage = 1;

        //確認Next Page的狀態
        public bool IsNextPageButtonEnable()
        {
            if (_currentPage == 2)
                return false;
            else
                return true;
        }

        //確認Previous Page的狀態
        public bool IsPreviousPageButtonEnable()
        {
            if (_currentPage == 1)
                return false;
            else
                return true;
        }

        //回傳現在的頁碼
        public string GetCurrentPage()
        {
            String currentPage = "Page: " + _currentPage.ToString() + "/2";
            return currentPage;
        }

        //加1頁
        public void AddOnePage()
        {
            _currentPage++;
        }

        //減1頁
        public void MinusOnePage()
        {
            _currentPage--;
        }

        //呼叫model的GetMealList
        public List<Meal> GetMealList()
        {
            return _model.GetMealList();
        }

        //呼叫model中的AddMeal
        public void AddMeal(string input)
        {
            _model.AddMeal(input);
        }

        //呼叫model中的AddToDisplayMealList
        public void AddToDisplayMealList()
        {
            _model.AddToDisplayMealList();
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
    }
}