using System;
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
        //variable to count total amount
        int summ = 0;

        public PizzaHut()
        {
            InitializeComponent();
        }

        //function to reset everything 
        private void ResetTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
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
        private void ResetLabel()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is Label)
                    {
                        (control as Label).Text = "0";
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }

            };
            func(Controls);
        }

        //function to reset checked boxes
        private void ResetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is CheckBox)
                    {
                        (control as CheckBox).Checked = false;
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }

            };
            func(Controls);
        }

        //Method to reset radio buttons
        private void ResetRadioButtons()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is RadioButton)
                    {
                        (control as RadioButton).Checked = false;
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }

            };
            func(Controls);
        }

        //code to reset the whole form
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            ResetCheckBoxes();
            ResetRadioButtons();


            summ = 0;
        }


        //Check boxes
        private void chkPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPepperoni.Checked == true)
            {
                summ += 7;
            }
            else
            {
                summ -= 7;
            }
            txtTotal.Text = summ.ToString();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraCheese.Checked == true)
            {
                summ += 7;
            }
            else
            {
                summ -= 7;
            }
            txtTotal.Text = summ.ToString();
        }

        private void chkMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushroom.Checked == true)
            {
                summ += 7;
            }
            else
            {
                summ -= 7;
            }
            txtTotal.Text = summ.ToString();
        }

        private void chkJalapeno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJalapeno.Checked == true)
            {
                summ += 7;
            }
            else
            {
                summ -= 7;
            }
            txtTotal.Text = summ.ToString();
        }

        private void chkPineapple_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPineapple.Checked == true)
            {
                summ += 7;
            }
            else
            {
                summ -= 7;
            }
            txtTotal.Text = summ.ToString();
        }

        private void chkDriedShrimp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDriedShrimp.Checked == true)
            {
                summ += 7;
            }
            else
            {
                summ -= 7;
            }
            txtTotal.Text = summ.ToString();
        }

        private void chkSpinach_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpinach.Checked == true)
            {
                summ += 7;
            }
            else
            {
                summ -= 7;
            }
            txtTotal.Text = summ.ToString();
        }

        private void chkShreddedChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShreddedChicken.Checked == true)
            {
                summ += 7;
            }
            else
            {
                summ -= 7;
            }
            txtTotal.Text = summ.ToString();
        }

        private void chkGroundedBeef_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGroundedBeef.Checked == true)
            {
                summ += 7;
            }
            else
            {
                summ -= 7;
            }
            txtTotal.Text = summ.ToString();
        }
        //Radio buttons
        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThick.Checked == true)
            {
                summ += 2;
            }
            else
            {
                summ -= 2;
            }
            txtTotal.Text = summ.ToString();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThin.Checked == true)
            {
                summ += 1;
            }
            else
            {
                summ -= 1;
            }
            txtTotal.Text = summ.ToString();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked == true)
            {
                summ += 20;
            }
            else
            {
                summ -= 20;
            }
            txtTotal.Text = summ.ToString();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMedium.Checked == true)
            {
                summ += 35;
            }
            else
            {
                summ -= 35;
            }
            txtTotal.Text = summ.ToString();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked == true)
            {
                summ += 55;
            }
            else
            {
                summ -= 55;
            }
            txtTotal.Text = summ.ToString();
        }
    }
}
