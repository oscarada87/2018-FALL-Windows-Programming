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
    public class OrderTests
    {
        [TestMethod()]
        public void OrderTest()
        {
            Order order = new Order();
            Assert.AreEqual(order.GetMenu()[0].Name, "大麥克");
        }

        [TestMethod()]
        public void AddNewMealToMenuTest()
        {
            Order order = new Order();
            Meal meal = new Meal("牛排", 999, "\resources\temp.jpg", "很貴的牛排", order.FindCategory("點心"));
            order.AddNewMealToMenu(meal);
            Assert.AreEqual(order.GetMenu().Last(), meal);
        }

        [TestMethod()]
        public void FindCategoryTest()
        {
            Order order = new Order();
            string name = order.FindCategory("漢堡").Name;
            Assert.AreEqual(name, "漢堡");
        }

        [TestMethod()]
        public void FindMealByNameTest()
        {
            Order order = new Order();
            Assert.AreEqual(order.FindMealByName("大麥克").Name, "大麥克");
            Assert.AreEqual(order.FindMealByName("找不到"), null);
        }

        [TestMethod()]
        public void GetMenuTest()
        {
            Order order = new Order();
            List<string> menuName = new List<string> { "大麥克", "雙層牛肉吉事堡", "安格斯黑牛堡", "嫩煎雞腿堡", "麥香雞", "麥克雞塊（6塊）", "麥克雞塊（9塊）", "勁辣雞腿堡", "麥脆雞（2塊）", "麥脆雞（3塊）", "黃金起司豬排堡", "麥香魚", "千島黃金蝦堡", "BLT 安格斯黑牛堡", "BLT 辣脆雞腿堡", "薯條（小包）", "薯條（中包）", "薯條（大包）", "薯餅", "蘋果派", "水果袋", "可口可樂（大）", "雪碧（大）", "冰紅茶（大）", "冰綠茶（大）", "冰奶茶（大）", "柳橙汁（大）"};
            List<Meal> menu = order.GetMenu();
            for(int i = 0; i < menu.Count; i++)
            {
                Assert.AreEqual(menu[i].Name, menuName[i]);
            }
        }

        [TestMethod()]
        public void GetDescriptionByNameTest()
        {
            Order order = new Order();
            string description = order.GetDescriptionByName("大麥克");
            Assert.AreEqual(description, "好吃的大麥克");
        }

        [TestMethod()]
        public void AddMealToMealListTest()
        {
            Order order = new Order();
            order.AddMealToMealList(order.FindMealByName("薯條（小包）"));
            Assert.AreEqual(order.GetMealList()[0].Name, "薯條（小包）");
        }

        [TestMethod()]
        public void ClearMealListTest()
        {
            Order order = new Order();
            order.AddMealToMealList(order.FindMealByName("薯條（小包）"));
            order.ClearMealList();
            Assert.AreEqual(order.GetMealList().Count, 0);
        }

        [TestMethod()]
        public void GetMealListTest()
        {
            Order order = new Order();
            Assert.AreEqual(order.GetMealList().Count, 0);
            order.AddMealToMealList(order.FindMealByName("薯條（小包）"));
            Assert.AreEqual(order.GetMealList()[0].Name, "薯條（小包）");
        }

        [TestMethod()]
        public void AddToDisplayMealListTest()
        {
            Order order = new Order();
            order.AddMealToMealList(order.FindMealByName("薯條（小包）"));
            order.AddToDisplayMealList();
            Assert.AreEqual(order.GetDisplayMealList()[0].Name, "薯條（小包）");
        }

        [TestMethod()]
        public void GetDisplayMealListTest()
        {
            Order order = new Order();
            order.AddMealToMealList(order.FindMealByName("薯條（小包）"));
            order.AddToDisplayMealList();
            Assert.AreEqual(order.GetDisplayMealList()[0].Name, "薯條（小包）");
        }

        [TestMethod()]
        public void DeleteFromDisplayMealListTest()
        {
            Order order = new Order();
            order.AddMealToMealList(order.FindMealByName("薯條（小包）"));
            order.AddMealToMealList(order.FindMealByName("薯條（中包）"));
            order.AddToDisplayMealList();
            order.DeleteFromDisplayMealList("薯條（小包）");
            Assert.AreEqual(order.GetDisplayMealList()[0].Name, "薯條（中包）");
        }

        [TestMethod()]
        public void GetTotalPriceTest()
        {
            Order order = new Order();
            order.AddMealToMealList(order.FindMealByName("薯條（小包）"));
            order.AddMealToMealList(order.FindMealByName("薯條（中包）"));
            order.AddToDisplayMealList();
            Assert.AreEqual(order.GetTotalPrice(), 74);
        }

        [TestMethod()]
        public void GetCategoriesTest()
        {
            Order order = new Order();
            List<string> categoryName = new List<string>{"漢堡", "點心", "飲料" };
            List<string> categories = order.GetCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                Assert.AreEqual(categories[i], categoryName[i]);
            }
        }

        [TestMethod()]
        public void ChangeCategoryNameTest()
        {
            Order order = new Order();
            List<string> categoryName = new List<string> { "漢堡123", "點心", "飲料" };
            order.ChangeCategoryName("漢堡", "漢堡123");
            List<string> categories = order.GetCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                Assert.AreEqual(categories[i], categoryName[i]);
            }
        }

        [TestMethod()]
        public void AddNewCategoryTest()
        {
            Order order = new Order();
            List<string> categoryName = new List<string> { "漢堡", "點心", "飲料", "甜點" };
            order.AddNewCategory("甜點");
            List<string> categories = order.GetCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                Assert.AreEqual(categories[i], categoryName[i]);
            }
        }

        [TestMethod()]
        public void DeleteCategoryTest()
        {
            Order order = new Order();
            List<string> categoryName = new List<string> { "漢堡", "點心"};
            order.DeleteCategory("飲料");
            List<string> categories = order.GetCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                Assert.AreEqual(categories[i], categoryName[i]);
            }
            order.DeleteCategory("找不到");
            categories = order.GetCategories();
            for (int i = 0; i < categories.Count; i++)
            {
                Assert.AreEqual(categories[i], categoryName[i]);
            }
        }

        [TestMethod()]
        public void DeleteMealTest()
        {
            Order order = new Order();
            List<string> menuName = new List<string> {"雙層牛肉吉事堡", "安格斯黑牛堡", "嫩煎雞腿堡", "麥香雞", "麥克雞塊（6塊）", "麥克雞塊（9塊）", "勁辣雞腿堡", "麥脆雞（2塊）", "麥脆雞（3塊）", "黃金起司豬排堡", "麥香魚", "千島黃金蝦堡", "BLT 安格斯黑牛堡", "BLT 辣脆雞腿堡", "薯條（小包）", "薯條（中包）", "薯條（大包）", "薯餅", "蘋果派", "水果袋", "可口可樂（大）", "雪碧（大）", "冰紅茶（大）", "冰綠茶（大）", "冰奶茶（大）", "柳橙汁（大）" };
            order.DeleteMeal("大麥克");
            List<Meal> menu = order.GetMenu();
            for (int i = 0; i < menu.Count; i++)
            {
                Assert.AreEqual(menu[i].Name, menuName[i]);
            }
            order.DeleteMeal("找不到");
            menu = order.GetMenu();
            for (int i = 0; i < menu.Count; i++)
            {
                Assert.AreEqual(menu[i].Name, menuName[i]);
            }
        }
    }
}