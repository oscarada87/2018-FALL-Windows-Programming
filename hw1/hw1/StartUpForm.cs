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
    public partial class StartUpForm : Form
    {
        private CustomerSideForm _CustomerSideForm;
        private RestaurantSideForm _RestaurantSideForm;

        public StartUpForm()
        {
            InitializeComponent();
        }

        //按下frontend button
        private void ClickFrontendButton(object sender, EventArgs e)
        {
            _CustomerSideForm = new CustomerSideForm(new POSCustomerSideModel());
            _CustomerSideForm.Show();
            
        }

        //按下backend button
        private void ClickBackendButton(object sender, EventArgs e)
        {
            _RestaurantSideForm = new RestaurantSideForm();
            _RestaurantSideForm.Show();
        }

        //按下exit button
        private void ClickExitButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
