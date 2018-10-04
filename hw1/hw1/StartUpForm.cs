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
        private StartUpFormPresentationModel _presentationModel;
        private CustomerSideForm _customerSideForm;
        private RestaurantSideForm _restaurantSideForm;

        public StartUpForm(StartUpFormPresentationModel presentationModel)
        {
            InitializeComponent();
            _presentationModel = presentationModel;
        }

        //按下frontend button
        private void ClickFrontEndButton(object sender, EventArgs e)
        {
            _customerSideForm = new CustomerSideForm(new CustomerFormPresentationModel());
            _customerSideForm.FormClosed += CloseForm;
            _customerSideForm.Show();
            _frontEndButton.Enabled = !_presentationModel.IsFrontEndFormExist();
        }

        //按下backend button
        private void ClickBackEndButton(object sender, EventArgs e)
        {
            _restaurantSideForm = new RestaurantSideForm();
            _restaurantSideForm.FormClosed += CloseForm;
            _restaurantSideForm.Show();
            _backEndButton.Enabled = !_presentationModel.IsBackEndFormExist();
        }

        //按下exit button
        private void ClickExitButton(object sender, EventArgs e)
        {
            this.Close();
            if (_presentationModel.IsFrontEndFormExist())
                _customerSideForm.Close();
            if (_presentationModel.IsBackEndFormExist())
                _restaurantSideForm.Close();
        }

        //當有視窗被關掉時，button enable 要重新檢測
        private void CloseForm(object sender, EventArgs e)
        {
            _frontEndButton.Enabled = !_presentationModel.IsFrontEndFormExist();
            _backEndButton.Enabled = !_presentationModel.IsBackEndFormExist();
        }
    }
}
