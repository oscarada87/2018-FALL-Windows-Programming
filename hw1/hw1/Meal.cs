using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide
{
    public class Meal
    {
        private int _mealNumber;
        private string _name;
        private int _price;
        private string _imageRelativePath;
        private string _description;

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

        public string ImageRelativePath
        {
            get
            {
                return _imageRelativePath;
            }
            set
            {
                _imageRelativePath = ImageRelativePath;
            }
        }

        public Meal(int mealNumber, string name, int price, string imageRelativePath)
        {
            this._mealNumber = mealNumber;
            this._name = name;
            this._price = price;
            this._imageRelativePath = imageRelativePath;
        }
    }
}
