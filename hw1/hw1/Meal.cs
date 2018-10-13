using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide
{
    public class Meal
    {
        private string _name;
        private int _price;
        private string _imageRelativePath;
        private string _description;
        private Category _category;

        //Constructor
        public Meal(string name, int price, string imageRelativePath, string description, Category category)
        {
            this._name = name;
            this._price = price;
            this._imageRelativePath = imageRelativePath;
            this._description = description;
            this._category = category;
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

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = Description;
            }
        }

        public Category Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = Category;
            }
        }
    }
}
