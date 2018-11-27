using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide
{
    public class CategoryState
    {
        private int _currentPage;
        private int _totalPage;
        private string _name;
        private const int ONE_PAGE_BUTTON_NUMBER = 9;

        public CategoryState(string name)
        {
            this._name = name;
            this._currentPage = 1;
            this._totalPage = 1;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                _currentPage = value;
            }
        }
        public int TotalPage
        {
            get
            {
                return _totalPage;
            }
            set
            {
                _totalPage = value;
            }
        }
        //更新最大頁數
        public void UpdateTotalPage(int number)
        {
            _totalPage = (number / ONE_PAGE_BUTTON_NUMBER) + 1;
        }
    }
}
