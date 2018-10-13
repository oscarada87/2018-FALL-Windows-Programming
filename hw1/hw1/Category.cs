using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide
{
    public class Category
    {
        private string _name;

        //Constructor
        public Category(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = Name;
            }
        }
    }
}
