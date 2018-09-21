using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1
{
    public partial class POSCustomerSideForm : Form
    {
        const int PRICE49 = 49;
        const int PRICE59 = 59;
        const int PRICE69 = 69;
        const int PRICE89 = 89;
        const int PRICE79 = 79;
        const int PRICE99 = 99;
        const int PRICE104 = 104;
        private POSCustomerSideModel _model = new POSCustomerSideModel();

        public POSCustomerSideForm(POSCustomerSideModel _model)
        {
            InitializeComponent();
        }

        //按下大麥克按鈕
        private void MealButton1Click(object sender, EventArgs e)
        {
            _model.AddMeal("大麥克", PRICE69);
        }

        //按下雙層牛肉吉事堡按鈕
        private void MealButton2Click(object sender, EventArgs e)
        {
            _model.AddMeal("雙層牛肉吉事堡", PRICE59);
        }

        //按下安格斯黑牛堡按鈕
        private void MealButton3Click(object sender, EventArgs e)
        {
            _model.AddMeal("安格斯黑牛堡", PRICE99);
        }

        //按下嫩煎雞腿堡按鈕
        private void MealButton4Click(object sender, EventArgs e)
        {
            _model.AddMeal("嫩煎雞腿堡", PRICE79);
        }

        //按下麥香雞按鈕
        private void MealButton5Click(object sender, EventArgs e)
        {
            _model.AddMeal("麥香雞", PRICE49);
        }

        //按下麥克雞塊（6塊）按鈕
        private void MealButton6Click(object sender, EventArgs e)
        {
            _model.AddMeal("麥克雞塊（6塊）", PRICE59);
        }

        //按下麥克雞塊（9塊）按鈕
        private void MealButton7Click(object sender, EventArgs e)
        {
            _model.AddMeal("麥克雞塊（9塊）", PRICE89);
        }

        //按下勁辣雞腿堡按鈕
        private void MealButton8Click(object sender, EventArgs e)
        {
            _model.AddMeal("勁辣雞腿堡", PRICE69);
        }

        //按下麥脆雞（2塊）按鈕
        private void MealButton9Click(object sender, EventArgs e)
        {
            _model.AddMeal("麥脆雞（2塊）", PRICE104);
        }

        //按下新增按鈕
        private void AddButton1Click(object sender, EventArgs e)
        {
            List<Meal> mealList = _model.GetMealList();

            mealList.ForEach(x=>
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(_mealGridView);
                row.Cells[0].Value = x.Name;
                row.Cells[1].Value = x.Price;
                _mealGridView.Rows.Add(row);
            });
            _model.AddToDisplayMealList();
            _model.ClearMealList();
            _totalLabel.Text = "Total: " + _model.GetTotalPrice() + "元";
        }
    }
}
