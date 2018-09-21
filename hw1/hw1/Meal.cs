using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    public class Meal
    {
        private string _name;
        private int _price;
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

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = Price;
            }
        }        

        public Meal(string name, int price)
        {
            this._name = name;
            this._price = price;
        }
    }
}
