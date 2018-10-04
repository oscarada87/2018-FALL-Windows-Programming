﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSCustomerSide
{
    public class StartUpFormPresentationModel
    {
        //Front End Form 是否存在
        public bool IsFrontEndFormExist()
        {
            FormCollection formCollection = Application.OpenForms;
            foreach (Form form in formCollection)
            {
                if (form.Text == "POS-Customer Side")
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
                if (form.Text == "POS-Restaurant Side")
                    return true;
            }
            return false;
        }
    }
}
