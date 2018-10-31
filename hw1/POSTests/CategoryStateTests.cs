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
    public class CategoryStateTests
    {
        [TestMethod()]
        public void CategoryStateTest()
        {
            CategoryState categoryState = new CategoryState("早餐");
            categoryState.Name = "排餐";
            categoryState.TotalPage = 3;
            Assert.AreEqual("排餐", categoryState.Name);
            Assert.AreEqual(3, categoryState.TotalPage);
        }
    }
}