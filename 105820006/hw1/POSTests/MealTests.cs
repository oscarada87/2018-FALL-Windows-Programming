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
    public class MealTests
    {
        [TestMethod()]
        public void MealTest()
        {
            Category steak = new Category("牛排");
            Meal meal = new Meal("牛排", 123, "8787.jpg", "好吃ㄉ牛排", steak);
            meal.Name = "豬排";
            Assert.AreEqual(meal.Name, "豬排");
            meal.Price = 456;
            Assert.AreEqual(meal.Price, 456);
            meal.ImageRelativePath = "9487.jpg";
            Assert.AreEqual(meal.ImageRelativePath, "9487.jpg");
            meal.Description = "好吃的豬排";
            Assert.AreEqual(meal.Description, "好吃的豬排");
            Category pork = new Category("豬排");
            meal.Category = pork;
            Assert.AreEqual(meal.Category.Name, "豬排");
        }
    }
}