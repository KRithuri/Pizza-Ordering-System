﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ordering_System
{
    public partial class PizzaHut : Form
    {
        public PizzaHut()
        {
            InitializeComponent();
        }
        //function to reset everything 
        private void ResetTexBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in Controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Text = "0";
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }

            };
            func(Controls);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
