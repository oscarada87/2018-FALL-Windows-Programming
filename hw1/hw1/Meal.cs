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

        public Meal(string name, int price)
        {
            this._name = name;
            this._price = price;
        }

        //取得價格
        public int GetPrice()
        {
            return _price;
        }

        //取得名字
        public string GetName()
        {
            return _name;
        }
    }
}
