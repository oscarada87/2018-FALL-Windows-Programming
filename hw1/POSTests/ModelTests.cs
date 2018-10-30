using Microsoft.VisualStudio.TestTools.UnitTesting;
using POSCustomerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSCustomerSide.Tests
{
    [TestClass()]
    public class ModelTests
    {
        PrivateObject _menuChanged;
        PrivateObject _categoryChanged;

        [TestMethod()]
        public void ChangeMealNameTest()
        {
            Model model = new Model();
            model.ChangeMealName("大麥克", "小麥克");
            model.ChangeMealName("大麥克", "小麥克");
            Assert.AreEqual(model.FindMealByName("小麥克").Name,"小麥克");
            Assert.AreEqual(model.FindMealByName("大麥克"), null);
        }

        [TestMethod()]
        public void ChangeMealPriceTest()
        {
            Model model = new Model();
            model.ChangeMealPrice("大麥克", "123");
            model.ChangeMealPrice("小麥克", "123");
            Assert.AreEqual(model.FindMealByName("大麥克").Price, 123);
        }

        [TestMethod()]
        public void ChangeMealCategoryTest()
        {
            Model model = new Model();
            model.ChangeMealCategory("大麥克", "點心");
            model.ChangeMealCategory("小麥克", "點心");
            Assert.AreEqual(model.FindMealByName("大麥克").Category.Name, "點心");
        }

        [TestMethod()]
        public void ChangeMealDescriptionTest()
        {
            Model model = new Model();
            model.ChangeMealDescription("大麥克", "不好吃的大麥克");
            model.ChangeMealDescription("小麥克", "不好吃的大麥克");
            Assert.AreEqual(model.FindMealByName("大麥克").Description, "不好吃的大麥克");
        }

        [TestMethod()]
        public void ChangeMealImagePathTest()
        {
            Model model = new Model();
            model.ChangeMealImagePath("大麥克", "123.jpg");
            model.ChangeMealImagePath("小麥克", "123.jpg");
            Assert.AreEqual(model.FindMealByName("大麥克").ImageRelativePath, "123.jpg");
        }

        [TestMethod()]
        public void AddNewMealToMenuTest()
        {
            Model model = new Model();
            Meal meal = new Meal("牛排", 999, "\resources\temp.jpg", "很貴的牛排", model.FindCategory("點心"));
            model.AddNewMealToMenu(meal);
            Assert.AreEqual(model.GetMenu().Last().Name, meal.Name);
        }

        [TestMethod()]
        public void DeleteMealTest()
        {
            Model model = new Model();
            model.DeleteMeal("小麥克");
            Assert.AreEqual(model.GetMenu().Count, 27);
            model.DeleteMeal("大麥克");
            Assert.AreEqual(model.FindMealByName("大麥克"), null);
            Assert.AreEqual(model.GetMenu().Count, 26);
        }

        [TestMethod()]
        public void ChangeCategoryNameTest()
        {
            Model model = new Model();
            model.ChangeCategoryName("漢堡", "好吃的漢堡");
            Assert.AreEqual(model.FindCategory("好吃的漢堡").Name , "好吃的漢堡");
            Assert.AreEqual(model.FindCategory("漢堡"), null);
        }

        [TestMethod()]
        public void AddNewCategoryTest()
        {
            Model model = new Model();
            model.AddNewCategory("甜點");
            Assert.AreEqual(model.FindCategory("甜點").Name, "甜點");
        }

        [TestMethod()]
        public void DeleteCategoryTest()
        {
            Model model = new Model();
            model.DeleteCategory("漢堡");
            Assert.AreEqual(model.FindCategory("漢堡"), null);
            Assert.AreEqual(model.GetCategories().Count, 2);
        }

        [TestMethod()]
        public void GetMealListTest()
        {
            Model model = new Model();
            Assert.AreEqual(model.GetMealList().Count, 0);
            model.AddMeal(model.FindMealByName("大麥克"));
            Assert.AreEqual(model.GetMealList()[0].Name, "大麥克");
        }

        [TestMethod()]
        public void GetDisplayMealListTest()
        {
            Model model = new Model();
            Assert.AreEqual(model.GetDisplayMealList().Count, 0);
            model.AddMeal(model.FindMealByName("大麥克"));
            model.AddToDisplayMealList();
            Assert.AreEqual(model.GetDisplayMealList()[0].Name, "大麥克");
        }

        [TestMethod()]
        public void AddMealTest()
        {
            Model model = new Model();
            Assert.AreEqual(model.GetMealList().Count, 0);
            model.AddMeal(model.FindMealByName("大麥克"));
            Assert.AreEqual(model.GetMealList()[0].Name, "大麥克");
        }

        [TestMethod()]
        public void FindMealByNameTest()
        {
            Model model = new Model();
            Meal bigMack = model.FindMealByName("大麥克");
            Assert.AreEqual(bigMack.Name, "大麥克");
            Assert.AreEqual(bigMack.Price, 69);
            Assert.AreEqual(bigMack.ImageRelativePath, "\\resources\\1.jpg");
            Assert.AreEqual(bigMack.Description, "好吃的大麥克");
            Assert.AreEqual(bigMack.Category.Name, "漢堡");
        }

        [TestMethod()]
        public void GetTotalPriceTest()
        {
            Model model = new Model();
            model.AddMeal(model.FindMealByName("薯條（小包）"));
            model.AddMeal(model.FindMealByName("薯條（中包）"));
            model.AddToDisplayMealList();
            Assert.AreEqual(model.GetTotalPrice(), 74);
        }

        [TestMethod()]
        public void ClearMealListTest()
        {
            Model model = new Model();
            model.AddMeal(model.FindMealByName("薯條（小包）"));
            Assert.AreEqual(model.GetMealList().Count, 1);
            model.ClearMealList();
            Assert.AreEqual(model.GetMealList().Count, 0);
        }

        [TestMethod()]
        public void AddToDisplayMealListTest()
        {
            Model model = new Model();
            Assert.AreEqual(model.GetDisplayMealList().Count, 0);
            model.AddMeal(model.FindMealByName("薯條（小包）"));
            model.AddToDisplayMealList();
            Assert.AreEqual(model.GetDisplayMealList()[0].Name, "薯條（小包）");
        }

        [TestMethod()]
        public void DeleteFromDisplayMealListTest()
        {
            Model model = new Model();
            Assert.AreEqual(model.GetDisplayMealList().Count, 0);
            model.AddMeal(model.FindMealByName("薯條（小包）"));
            model.AddToDisplayMealList();
            Assert.AreEqual(model.GetDisplayMealList().Count, 1);
            model.DeleteFromDisplayMealList("薯條（小包）");
            Assert.AreEqual(model.GetDisplayMealList().Count, 0);
        }

        [TestMethod()]
        public void GetCategoriesTest()
        {
            Model model = new Model();
            List<string> categoryName = new List<string> { "漢堡", "點心", "飲料" };
            List<string> categories = model.GetCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                Assert.AreEqual(categories[i], categoryName[i]);
            }
        }

        [TestMethod()]
        public void GetMenuTest()
        {
            Model model = new Model();
            List<string> menuName = new List<string> { "大麥克", "雙層牛肉吉事堡", "安格斯黑牛堡", "嫩煎雞腿堡", "麥香雞", "麥克雞塊（6塊）", "麥克雞塊（9塊）", "勁辣雞腿堡", "麥脆雞（2塊）", "麥脆雞（3塊）", "黃金起司豬排堡", "麥香魚", "千島黃金蝦堡", "BLT 安格斯黑牛堡", "BLT 辣脆雞腿堡", "薯條（小包）", "薯條（中包）", "薯條（大包）", "薯餅", "蘋果派", "水果袋", "可口可樂（大）", "雪碧（大）", "冰紅茶（大）", "冰綠茶（大）", "冰奶茶（大）", "柳橙汁（大）" };
            List<Meal> menu = model.GetMenu();
            for (int i = 0; i < menu.Count; i++)
            {
                Assert.AreEqual(menu[i].Name, menuName[i]);
            }
        }

        [TestMethod()]
        public void FindCategoryTest()
        {
            Model model = new Model();
            Assert.AreEqual(model.FindCategory("飲料").Name, "飲料");
            Assert.AreEqual(model.FindCategory("找不到"), null);
        }

        [TestMethod()]
        public void IsMealListEmptyTest()
        {
            Model model = new Model();
            Assert.AreEqual(model.IsMealListEmpty(), true);
            model.AddMeal(model.FindMealByName("薯條（小包）"));
            Assert.AreEqual(model.IsMealListEmpty(), false);
        }

        [TestMethod()]
        public void NotifyMenuChangedObserverTest()
        {
            Model model = new Model();
            model.NotifyMenuChangedObserver();
        }

        [TestMethod()]
        public void NotifyCategoryChangedObserverTest()
        {
            Model model = new Model();
            model.NotifyCategoryChangedObserver();
        }
    }
}