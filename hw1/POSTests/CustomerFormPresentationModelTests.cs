using Microsoft.VisualStudio.TestTools.UnitTesting;
using POSCustomerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace POSCustomerSide.Tests
{
    [TestClass()]
    public class CustomerFormPresentationModelTests
    {
        [TestMethod()]
        public void GetMealButtonLocationTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            List<int> buttonLocation = model.GetMealButtonLocation(0);
            Assert.AreEqual(buttonLocation[0], 10);
            Assert.AreEqual(buttonLocation[1], 10);
            buttonLocation = model.GetMealButtonLocation(10);
            Assert.AreEqual(buttonLocation[0], 170);
            Assert.AreEqual(buttonLocation[1], 10);
        }

        [TestMethod()]
        public void UpdateTotalPageTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            model.UpdateTotalPage(10, 0);
            PrivateObject target = new PrivateObject (model);
            List<CategoryState> categoryState = (List<CategoryState>)target.GetFieldOrProperty("_categoriesState");
            Assert.AreEqual(categoryState[0].TotalPage, 2);
            model.UpdateTotalPage(6, 1);
            Assert.AreEqual(categoryState[1].TotalPage, 1);
        }

        [TestMethod()]
        public void GetMealButtonCategoryIndexTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            Assert.AreEqual(model.GetMealButtonCategoryIndex(model.FindMealByName("大麥克")), 0);
        }

        [TestMethod()]
        public void GetMealButtonVisibleTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            Assert.IsTrue(model.GetMealButtonVisible("漢堡", 0));
            Assert.IsFalse(model.GetMealButtonVisible("漢堡", 11));
            Assert.IsFalse(model.GetMealButtonVisible("找不到", 11));
        }

        [TestMethod()]
        public void IsNextPageButtonEnableTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            PrivateObject target = new PrivateObject(model);
            List<CategoryState> categoryState = (List<CategoryState>)target.GetFieldOrProperty("_categoriesState");
            categoryState[0].CurrentPage = 0;
            Assert.IsTrue(model.IsNextPageButtonEnable("漢堡"));
            categoryState[0].CurrentPage = 1;
            Assert.IsFalse(model.IsNextPageButtonEnable("漢堡"));
            Assert.IsFalse(model.IsNextPageButtonEnable("找不到"));
        }

        [TestMethod()]
        public void IsPreviousPageButtonEnableTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            PrivateObject target = new PrivateObject(model);
            List<CategoryState> categoryState = (List<CategoryState>)target.GetFieldOrProperty("_categoriesState");
            categoryState[0].CurrentPage = 1;
            Assert.IsFalse(model.IsPreviousPageButtonEnable("漢堡"));
            categoryState[0].CurrentPage = 2;
            Assert.IsTrue(model.IsPreviousPageButtonEnable("漢堡"));
            Assert.IsFalse(model.IsPreviousPageButtonEnable("找不到"));
        }

        [TestMethod()]
        public void IsAddButtonEnableTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            Assert.IsFalse(model.IsAddButtonEnable());
            model.AddMeal(model.FindMealByName("大麥克"));
            Assert.IsTrue(model.IsAddButtonEnable());
        }

        [TestMethod()]
        public void GetCurrentPageTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            Assert.AreEqual(model.GetCurrentPage("漢堡"), "Page: 1/1");
            Assert.AreEqual(model.GetCurrentPage("找不到"), "");
        }

        [TestMethod()]
        public void AddOnePageTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            model.UpdateTotalPage(15, 0);
            model.AddOnePage("漢堡");
            PrivateObject target = new PrivateObject(model);
            List<CategoryState> categoryState = (List<CategoryState>)target.GetFieldOrProperty("_categoriesState");
            Assert.AreEqual(categoryState[0].CurrentPage, 2);
        }

        [TestMethod()]
        public void RemoveOnePageTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            model.UpdateTotalPage(15, 0);
            model.AddOnePage("漢堡");
            PrivateObject target = new PrivateObject(model);
            List<CategoryState> categoryState = (List<CategoryState>)target.GetFieldOrProperty("_categoriesState");
            Assert.AreEqual(categoryState[0].CurrentPage, 2);
            model.RemoveOnePage("漢堡");
            categoryState = (List<CategoryState>)target.GetFieldOrProperty("_categoriesState");
            Assert.AreEqual(categoryState[0].CurrentPage, 1);
        }

        [TestMethod()]
        public void GetMealListTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            model.AddMeal(model.FindMealByName("薯條（小包）"));
            Assert.AreEqual(model.GetMealList()[0].Name, "薯條（小包）");
        }

        [TestMethod()]
        public void GetDisplayMealListTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            model.AddMeal(model.FindMealByName("薯條（小包）"));
            model.AddToDisplayMealList();
            Assert.AreEqual(model.GetDisplayMealList()[0].Name, "薯條（小包）");
        }

        [TestMethod()]
        public void AddMealTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            model.AddMeal(model.FindMealByName("薯條（小包）"));
            model.AddMeal(model.FindMealByName("薯條（中包）"));
            Assert.AreEqual(model.GetMealList()[0].Name, "薯條（小包）");
            Assert.AreEqual(model.GetMealList()[1].Name, "薯條（中包）");
        }

        [TestMethod()]
        public void AddToDisplayMealListTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            model.AddMeal(model.FindMealByName("薯條（小包）"));
            model.AddMeal(model.FindMealByName("薯條（中包）"));
            model.AddToDisplayMealList();
            Assert.AreEqual(model.GetDisplayMealList()[0].Name, "薯條（小包）");
            Assert.AreEqual(model.GetDisplayMealList()[1].Name, "薯條（中包）");
        }

        [TestMethod()]
        public void DeleteFromDisplayMealListTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            model.AddMeal(model.FindMealByName("薯條（小包）"));
            model.AddMeal(model.FindMealByName("薯條（中包）"));
            model.AddToDisplayMealList();
            Assert.AreEqual(model.GetDisplayMealList().Count, 2);
            model.DeleteFromDisplayMealList("薯條（小包）");
            Assert.AreEqual(model.GetDisplayMealList().Count, 1);
            model.DeleteFromDisplayMealList("薯條（中包）");
            Assert.AreEqual(model.GetDisplayMealList().Count, 0);
        }

        [TestMethod()]
        public void ClearMealListTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            model.AddMeal(model.FindMealByName("薯條（小包）"));
            model.AddMeal(model.FindMealByName("薯條（中包）"));
            Assert.AreEqual(model.GetMealList().Count, 2);
            model.ClearMealList();
            Assert.AreEqual(model.GetMealList().Count, 0);
        }

        [TestMethod()]
        public void GetTotalPriceTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            model.AddMeal(model.FindMealByName("薯條（小包）"));
            model.AddMeal(model.FindMealByName("薯條（中包）"));
            model.AddToDisplayMealList();
            Assert.AreEqual(model.GetTotalPrice(), 74);
        }

        [TestMethod()]
        public void GetCategoriesTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
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
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            List<string> menuName = new List<string> { "大麥克", "雙層牛肉吉事堡", "安格斯黑牛堡", "嫩煎雞腿堡", "麥香雞", "麥克雞塊（6塊）", "麥克雞塊（9塊）", "勁辣雞腿堡", "麥脆雞（2塊）", "麥脆雞（3塊）", "黃金起司豬排堡", "麥香魚", "千島黃金蝦堡", "BLT 安格斯黑牛堡", "BLT 辣脆雞腿堡", "薯條（小包）", "薯條（中包）", "薯條（大包）", "薯餅", "蘋果派", "水果袋", "可口可樂（大）", "雪碧（大）", "冰紅茶（大）", "冰綠茶（大）", "冰奶茶（大）", "柳橙汁（大）" };
            List<Meal> menu = model.GetMenu();
            for (int i = 0; i < menu.Count; i++)
            {
                Assert.AreEqual(menu[i].Name, menuName[i]);
            }
        }

        [TestMethod()]
        public void FindMealByNameTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            Assert.AreEqual("大麥克", model.FindMealByName("大麥克").Name);
        }

        [TestMethod()]
        public void NotifyMenuChangedObserverTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            model.NotifyMenuChangedObserver();
        }

        [TestMethod()]
        public void NotifyCategoryChangedObserverTest()
        {
            CustomerFormPresentationModel model = new CustomerFormPresentationModel(new Model());
            model.NotifyCategoryChangedObserver();
        }
    }
}