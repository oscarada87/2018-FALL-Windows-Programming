using System;
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
        private const int TOTAL_PAGE = 2;

        //確認Next Page的狀態
        public bool IsNextPageButtonEnable()
        {
            if (_currentPage == TOTAL_PAGE)
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
        public void AddMeal(int buttonNumber)
        {
            _model.AddMeal(buttonNumber);
        }

        //呼叫model中的AddToDisplayMealList
        public void AddToDisplayMealList()
        {
            _model.AddToDisplayMealList();
        }

        //呼叫model中的DeleteFromDisplayMealList
        public void DeleteFromDisplayMealList(int mealIndex)
        {
            _model.DeleteFromDisplayMealList(mealIndex);
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

        //呼叫model中的GetImagePath
        public string GetImagePath(int buttonIndex)
        {
            return _model.GetImagePath(buttonIndex);
        }

        //呼叫model中的GetPrice
        public string GetPrice(int buttonIndex)
        {
            return _model.GetPrice(buttonIndex);
        }

        //呼叫model中的GetDescriptionByName
        public string GetDescriptionByName(string mealName)
        {
            return _model.GetDescriptionByName(mealName);
        }

        //呼叫model中的GetDescriptionByIndex
        public string GetDescriptionByIndex(int mealIndex)
        {
            return _model.GetDescriptionByIndex(mealIndex);
        }
    }
}
