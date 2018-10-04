using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POSCustomerSide
{
    public class Order
    {
        string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
        const string MENU_RELATIVE_PATH = @"\resources\menu.txt";
        private List<Meal> _mealList = new List<Meal>();
        private List<Meal> _displayMealList = new List<Meal>();
        private List<Meal> _menuList = new List<Meal>();

        public Order()
        {
            ReadMenuList();
        }

        //將外部的menu讀進來
        private void ReadMenuList()
        {
            string line;
            StreamReader file = new StreamReader(projectPath + MENU_RELATIVE_PATH, System.Text.Encoding.Default);
            while ((line = file.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                Meal meal = new Meal(int.Parse(data[0]), data[1], int.Parse(data[2]), data[3]);
                _menuList.Add(meal);
            }
        }

        //取得Menu的背景圖片位置
        public string GetImagePath(int buttonIndex)
        {
            string path = projectPath + _menuList[buttonIndex].ImageRelativePath;
            return path;
        }

        //取得Menu的價錢
        public string GetPrice(int buttonIndex)
        {
            return _menuList[buttonIndex].Price.ToString();
        }

        //新增一項餐點
        public void AddMeal(int buttonIndex)
        {
            //Console.WriteLine(buttonIndex);
            _mealList.Add(_menuList[buttonIndex]);
        }

        //清除要新增的餐點列表
        public void ClearMealList()
        {
            _mealList.Clear();
        }

        //取得要新增的餐點列表
        public List<Meal> GetMealList()
        {
            return _mealList;
        }

        //取得要新增的餐點數量
        public int GetLengthOfMealList()
        {
            return _mealList.Count;
        }

        //將要新增的餐點加進display中
        public void AddToDisplayMealList()
        {
            _displayMealList.AddRange(_mealList);
        }

        //取得總價
        public int GetTotalPrice()
        {
            int total = _displayMealList.Sum(x => x.Price);
            return total;
        }
    }
}
