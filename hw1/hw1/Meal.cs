using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Meal
    {
        public string name;
        public int price;
        public Meal(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        //取得價格
        public int GetPrice()
        {
            return price;
        }
        //取得名字
        public string GetName()
        {
            return name;
        }
    }
}
