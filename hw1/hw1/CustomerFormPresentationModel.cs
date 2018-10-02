using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide
{
    class CustomerFormPresentationModel
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


    }
}
