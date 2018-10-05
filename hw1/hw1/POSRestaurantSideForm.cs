using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSCustomerSide
{
    public partial class RestaurantSideForm : Form
    {
        public RestaurantSideForm()
        {
            InitializeComponent();
            this._okButton.Click += ClickButton;
        }

        //按下ok按鈕
        private void ClickButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
