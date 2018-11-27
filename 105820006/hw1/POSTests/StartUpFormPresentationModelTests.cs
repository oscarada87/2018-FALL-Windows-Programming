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
    public class StartUpFormPresentationModelTests
    {
        [TestMethod()]
        public void IsFrontEndFormExistTest()
        {
            StartUpFormPresentationModel model = new StartUpFormPresentationModel();
            Assert.IsFalse(model.IsFrontEndFormExist());
        }

        [TestMethod()]
        public void IsBackEndFormExistTest()
        {
            StartUpFormPresentationModel model = new StartUpFormPresentationModel();
            Assert.IsFalse(model.IsBackEndFormExist());
        }
    }
}