using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSCustomerSide
{
    public class StartUpFormPresentationModel
    {
        private const string FRONT_END_FORM_NAME = "POS-Customer Side";
        private const string BACK_END_FORM_NAME = "POS-Restaurant Side";

        //Front End Form 是否存在
        public bool IsFrontEndFormExist()
        {
            FormCollection formCollection = Application.OpenForms;
            foreach (Form form in formCollection)
            {
                if (form.Text == FRONT_END_FORM_NAME)
                    return true;
            }
            return false;
        }

        //Back End Form 是否存在
        public bool IsBackEndFormExist()
        {
            FormCollection formCollection = Application.OpenForms;
            foreach (Form form in formCollection)
            {
                if (form.Text == BACK_END_FORM_NAME)
                    return true;
            }
            return false;
        }
    }
}
