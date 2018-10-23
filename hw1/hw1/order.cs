using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace POSCustomerSide
{
    public class Order
    {
        string _projectPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
        private const string MENU_RELATIVE_PATH = @"\resources\menu.txt";
        private const char COMMA = ',';
        private const int TWO = 2;
        private const int THREE = 3;
        private const int FOUR = 4;
        private const int FIVE = 5;
        private List<Meal> _menuList = new List<Meal>();
        private List<Category> _categories = new List<Category>();
        private List<Meal> _mealList = new List<Meal>();
        private List<Meal> _displayMealList = new List<Meal>();

        //Constructor
        public Order()
        {
            ReadCategories();
            ReadMenuList();
            //Debug();
        }

        /*private void Debug()
        {
            _menuList.ForEach(x =>
            {
                Console.WriteLine(x.Name);
            });
        }*/

        //讀取Categories
        private void ReadCategories()
        {
            string line;
            StreamReader file = new StreamReader(_projectPath + MENU_RELATIVE_PATH, System.Text.Encoding.Default);
            HashSet<string> categories = new HashSet<string>();
            while ((line = file.ReadLine()) != null)
            {
                string[] data = line.Split(COMMA);
                categories.Add(data[0]);
            }
            InitialCategories(categories);
        }

        //讀取meal
        private void ReadMenuList()
        {
            string line;
            StreamReader file = new StreamReader(_projectPath + MENU_RELATIVE_PATH, System.Text.Encoding.Default);
            while ((line = file.ReadLine()) != null)
            {
                string[] data = line.Split(COMMA);
                Meal meal = new Meal(data[1], int.Parse(data[TWO]), data[THREE], data[FOUR], FindCategory(data[0]));
                _menuList.Add(meal);
            }
        }

        //初始化Categories
        private void InitialCategories(HashSet<string> categories)
        {
            foreach (string category in categories)
            {
                _categories.Add(new Category(category));
            }
        }

        //新增餐點到菜單
        public void AddNewMealToMenu(Meal meal)
        {
            _menuList.Add(meal);
        }

        //透過名字找到類別
        public Category FindCategory(string categoryName)
        {
            foreach (Category category in _categories)
            {
                if (category.Name == categoryName)
                    return category;
            }
            return null;
        }

        //透過名字找到餐點
        public Meal FindMealByName(string mealName)
        {
            foreach (var meal in _menuList)
            {
                if (meal.Name == mealName)
                    return meal;
            }
            //Console.WriteLine("Not Found!");
            return null;
        }

        //取得menu
        public List<Meal> GetMenu()
        {
            return _menuList;
        }

        //取得Menu的背景圖片位置
        public string GetImagePath(int buttonIndex)
        {
            string path = _projectPath + _menuList[buttonIndex].ImageRelativePath;
            return path;
        }

        //取得Menu的價錢
        public string GetPrice(int buttonIndex)
        {
            return _menuList[buttonIndex].Price.ToString();
        }

        //取得Menu的描述透過名字
        public string GetDescriptionByName(string mealName)
        {
            Meal meal = FindMealByName(mealName);
            return meal.Description;
        }

        //取得Menu的描述透過Index
        public string GetDescriptionByIndex(int mealIndex)
        {
            return _menuList[mealIndex].Description;
        }

        //新增一項餐點
        public void AddMealToMealList(Meal meal)
        {
            _mealList.Add(meal);
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

        //取得顯示Meal List
        public List<Meal> GetDisplayMealList()
        {
            return _displayMealList;
        }

        //刪除display中指定的meal
        public void DeleteFromDisplayMealList(string mealName)
        {
            foreach (Meal meal in _displayMealList)
            {
                if (meal.Name == mealName)
                    _displayMealList.Remove(meal);
                break;
            }
        }

        //取得總價
        public int GetTotalPrice()
        {
            int total = _displayMealList.Sum(x => x.Price);
            return total;
        }

        //取得Categories名字列表
        public List<string> GetCategories()
        {
            List<string> categoriesName = new List<string>();
            _categories.ForEach(x =>
            {
                categoriesName.Add(x.Name);
            });
            return categoriesName;
        }

        //更改 category 名字
        public void ChangeCategoryName(string categoryOldName, string categoryNewName)
        {
            foreach (Category category in _categories)
            {
                if (category.Name == categoryOldName)
                    category.Name = categoryNewName;
            }
        }

        //新增新的 category
        public void AddNewCategory(string categoryName)
        {
            if (FindCategory(categoryName) == null)
                _categories.Add(new Category(categoryName));
        }

        //刪除指定的 category
        public void DeleteCategory(string categoryName)
        {
            foreach (Category category in _categories)
            {
                if (category.Name == categoryName)
                {
                    _categories.Remove(category);
                    return;
                }
                //Console.WriteLine("ERROR --- 沒有找到相對應的category");
            }
        }

        //刪除指定的 Meal
        public void DeleteMeal(string mealName)
        {
            foreach (Meal meal in _menuList)
            {
                if (meal.Name == mealName)
                {
                    _menuList.Remove(meal);
                    return;
                }
            }
            //Console.WriteLine("ERROR --- 沒有找到相對應的餐點");
        }
    }
}
