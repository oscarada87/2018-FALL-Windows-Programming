using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestProject
{
    /// <summary>
    /// MainFormUITest 的摘要說明
    /// </summary>
    [CodedUITest]
    public class MainFormUITest
    {
        //string _projectPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
        private const string FILE_PATH = @"..\..\..\hw1\bin\Debug\POS.exe";
        private const string CALCULATOR_TITLE = "StartUp";
        private const string RESULT_PRICE_CONTROL_NAME = "totalPrice";

        public MainFormUITest()
        {
        }

        [TestInitialize()]
        public void Initialize()
        {
            Robot.SetDelayBetweenActions(3);
            Robot.Initialize(FILE_PATH, CALCULATOR_TITLE);
        }

        private void RunScriptAllOrder()
        {
            Robot.ClickButton("Start the Cutomer Program (Frontend)");
            Robot.SetForm("POS-Customer Side");
            Robot.ClickButton("大麥克\n69元");
            Robot.ClickButton("雙層牛肉吉事堡\n59元");
            Robot.ClickButton("安格斯黑牛堡\n99元");
            Robot.ClickButton("嫩煎雞腿堡\n79元");
            Robot.ClickButton("麥香雞\n49元");
            Robot.ClickButton("麥克雞塊（6塊）\n59元");
            Robot.ClickButton("麥克雞塊（9塊）\n89元");
            Robot.ClickButton("勁辣雞腿堡\n69元");
            Robot.ClickButton("麥脆雞（2塊）\n104元");
            Robot.ClickButton("Next Page");
            Robot.ClickButton("麥脆雞（3塊）\n156元");
            Robot.ClickButton("黃金起司豬排堡\n49元");
            Robot.ClickButton("麥香魚\n49元");
            Robot.ClickButton("千島黃金蝦堡\n69元");
            Robot.ClickButton("BLT 安格斯黑牛堡\n109元");
            Robot.ClickButton("BLT 辣脆雞腿堡\n109元");
            Robot.ClickButton("orderMeal");
            Robot.ClickButton("Previous Page");
            Robot.ClickTabControl("點心");
            Robot.ClickButton("薯條（小包）\n32元");
            Robot.ClickButton("薯條（中包）\n42元");
            Robot.ClickButton("薯條（大包）\n55元");
            Robot.ClickButton("薯餅\n32元");
            Robot.ClickButton("蘋果派\n32元");
            Robot.ClickButton("水果袋\n39元");
            Robot.ClickButton("orderMeal");
            Robot.ClickTabControl("飲料");
            Robot.ClickButton("可口可樂（大）\n40元");
            Robot.ClickButton("雪碧（大）\n40元");
            Robot.ClickButton("冰紅茶（大）\n40元");
            Robot.ClickButton("冰綠茶（大）\n40元");
            Robot.ClickButton("冰奶茶（大）\n45元");
            Robot.ClickButton("柳橙汁（大）\n45元");
            Robot.ClickButton("orderMeal");
        }

        [TestMethod]
        public void TestAllOrder()
        {
            RunScriptAllOrder();
            string EXPECTED_VALUE = "Total: 1699元";
            Robot.AssertText(RESULT_PRICE_CONTROL_NAME, EXPECTED_VALUE);
        }
        
        private void RunScriptTestDataGridView()
        {
            Robot.ClickButton("Start the Cutomer Program (Frontend)");
            Robot.SetForm("POS-Customer Side");
            Robot.ClickButton("大麥克\n69元");
            Robot.ClickTabControl("點心");
            Robot.ClickButton("薯餅\n32元");
            Robot.ClickTabControl("飲料");
            Robot.ClickButton("冰奶茶（大）\n45元");
            Robot.ClickButton("冰奶茶（大）\n45元");
            Robot.ClickButton("orderMeal");
            Robot.DeleteDataGridViewRowByIndex("dataGridView", "4");        
        }

        private void RunScriptTestQTY()
        {
            Robot.SetDataGridViewQuantity("dataGridView", "3", "2");
            Robot.ClickTabControl("漢堡");
        }

        [TestMethod]
        public void TestDataGridView()
        {
            RunScriptTestDataGridView();
            string EXPECTED_VALUE = "Total: 146元";
            Robot.AssertText(RESULT_PRICE_CONTROL_NAME, EXPECTED_VALUE);
            RunScriptTestQTY();
            EXPECTED_VALUE = "Total: 191元";
            Robot.AssertText(RESULT_PRICE_CONTROL_NAME, EXPECTED_VALUE);
        }

        private void RunScriptTestModifiedMeal()
        {
            Robot.ClickButton("Start the Cutomer Program (Frontend)");
            Robot.ClickButton("Start the Restaurant Program (Backend)");
            Robot.SetForm("POS-Customer Side");
            Robot.ClickButton("大麥克\n69元");
            Robot.ClickButton("orderMeal");
            Robot.SetForm("POS-Restaurant Side");
            Robot.ClickTabControl("Meal Manager");
            Robot.ClickListViewByValue("mealListBox", "大麥克");
            Robot.SetEdit("mealNameBox", "Bigmac");
            Robot.SetEdit("mealDescriptionBox", "Delicious bigmac!");
            Robot.SetEdit("mealPriceBox", "99");
            Robot.SetComboBox("mealCategoryBox", "點心");
            Robot.ClickButton("Browse");
            Robot.SelectFileByOpenFileDialog("開啟", new string[] { "temp.jpg"});
            Robot.ClickButton("mealSave");
            Robot.SetForm("POS-Customer Side");
        }

        [TestMethod]
        public void TestModifiedMeal()
        {
            RunScriptTestModifiedMeal();
            string EXPECTED_VALUE = "Total: 99元";
            Robot.AssertText(RESULT_PRICE_CONTROL_NAME, EXPECTED_VALUE);
        }

        private void RunScriptTestAddMeal()
        {
            Robot.ClickButton("Start the Restaurant Program (Backend)");
            Robot.SetForm("POS-Restaurant Side");
            Robot.ClickTabControl("Meal Manager");
            Robot.ClickButton("addMeal");
            Robot.SetEdit("mealNameBox", "smallmac");
            Robot.SetEdit("mealDescriptionBox", "Delicious smallmac!");
            Robot.SetEdit("mealPriceBox", "19");
            Robot.SetComboBox("mealCategoryBox", "漢堡");
            Robot.ClickButton("Browse");
            Robot.SelectFileByOpenFileDialog("開啟", new string[] { "1.jpg" });
            Robot.ClickButton("mealSave");
            Robot.ClickListViewByValue("mealListBox", "大麥克");
            Robot.ClickButton("deleteMeal");
            Robot.CloseWindow("POS-Restaurant Side");
            Robot.SetForm("StartUp");
            Robot.ClickButton("Start the Cutomer Program (Frontend)");
            Robot.SetForm("POS-Customer Side");
            Robot.ClickButton("Next Page");
            Robot.ClickButton("smallmac\n19元");
            Robot.ClickButton("orderMeal");       
        }

        [TestMethod]
        public void TestAddMeal()
        {
            RunScriptTestAddMeal();
            string EXPECTED_VALUE = "Total: 19元";
            Robot.AssertText(RESULT_PRICE_CONTROL_NAME, EXPECTED_VALUE);
        }

        private void RunScriptTestAddCategory()
        {
            Robot.ClickButton("Start the Restaurant Program (Backend)");
            Robot.SetForm("POS-Restaurant Side");
            Robot.ClickTabControl("Category Manager");
            Robot.ClickButton("addCategory");
            Robot.SetEdit("categoryNameBox", "sushi");
            Robot.ClickButton("categorySave");
            Robot.ClickButton("addCategory");
            Robot.SetEdit("categoryNameBox", "test");
            Robot.ClickButton("categorySave");
            Robot.ClickTabControl("Meal Manager");
            Robot.ClickButton("addMeal");
            Robot.SetEdit("mealNameBox", "smallsushi");
            Robot.SetEdit("mealDescriptionBox", "Delicious smallsushi!");
            Robot.SetEdit("mealPriceBox", "29");
            Robot.SetComboBox("mealCategoryBox", "sushi");
            Robot.ClickButton("Browse");
            Robot.SelectFileByOpenFileDialog("開啟", new string[] { "1.jpg" });
            Robot.ClickButton("mealSave");
            Robot.ClickTabControl("Category Manager");
            Robot.ClickListViewByValue("categoryListBox", "sushi");
            Robot.ClickListViewByValue("categoryListBox", "test");
            Robot.ClickButton("deleteCategory");
            Robot.CloseWindow("POS-Restaurant Side");
            Robot.SetForm("StartUp");
            Robot.ClickButton("Start the Cutomer Program (Frontend)");
            Robot.SetForm("POS-Customer Side");
            Robot.ClickTabControl("sushi");
            Robot.ClickButton("smallsushi\n29元");
            Robot.ClickButton("orderMeal");
        }

        [TestMethod]
        public void TestAddCategory()
        {
            RunScriptTestAddCategory();
            string EXPECTED_VALUE = "Total: 29元";
            Robot.AssertText(RESULT_PRICE_CONTROL_NAME, EXPECTED_VALUE);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }
        #region 其他測試屬性

        // 您可以使用下列其他屬性撰寫測試: 

        ////在每項測試執行前先使用 TestInitialize 執行程式碼 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式化 UI 測試的程式碼]，並選取其中一個功能表項目。
        //}

        ////在每項測試執行後使用 TestCleanup 執行程式碼
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式化 UI 測試的程式碼]，並選取其中一個功能表項目。
        //}

        #endregion

        /// <summary>
        ///取得或設定提供目前測試回合
        ///相關資訊與功能的測試內容。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

    }
}
