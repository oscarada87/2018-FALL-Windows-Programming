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
        private POSCustomerSideModel model = new POSCustomerSideModel();

        public POSCustomerSideForm(POSCustomerSideModel model)
        {
            InitializeComponent();
        }

        //按下大麥克按鈕
        private void _meal_button_1_Click(object sender, EventArgs e)
        {
            model.AddMeal("大麥克", 69);
        }

        //按下雙層牛肉吉事堡按鈕
        private void _meal_button_2_Click(object sender, EventArgs e)
        {
            model.AddMeal("雙層牛肉吉事堡", 59);
        }

        //按下安格斯黑牛堡按鈕
        private void _meal_button_3_Click(object sender, EventArgs e)
        {
            model.AddMeal("安格斯黑牛堡", 99);
        }

        //按下嫩煎雞腿堡按鈕
        private void _meal_button_4_Click(object sender, EventArgs e)
        {
            model.AddMeal("嫩煎雞腿堡", 79);
        }

        //按下麥香雞按鈕
        private void _meal_button_5_Click(object sender, EventArgs e)
        {
            model.AddMeal("麥香雞", 49);
        }

        //按下麥克雞塊（6塊）按鈕
        private void _meal_button_6_Click(object sender, EventArgs e)
        {
            model.AddMeal("麥克雞塊（6塊）", 59);
        }

        //按下麥克雞塊（9塊）按鈕
        private void _meal_button_7_Click(object sender, EventArgs e)
        {
            model.AddMeal("麥克雞塊（9塊）", 89);
        }

        //按下勁辣雞腿堡按鈕
        private void _meal_button_8_Click(object sender, EventArgs e)
        {
            model.AddMeal("勁辣雞腿堡", 69);
        }

        //按下麥脆雞（2塊）按鈕
        private void _meal_button_9_Click(object sender, EventArgs e)
        {
            model.AddMeal("麥脆雞（2塊）", 104);
        }

        //按下新增按鈕
        private void _add_button_Click(object sender, EventArgs e)
        {
            _total_label.Text = "Total: " + model.GetTotalPrice() + "元";
            int length = model.GetLengthOfMealList();
            for (int i = 1; i <= length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(_record_datagridview);
                row.Cells[0].Value = "123";
                row.Cells[1].Value = 456;
                _record_datagridview.Rows.Add(row);
            }
            
            
        }
    }
}
