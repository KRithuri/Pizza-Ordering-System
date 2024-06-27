namespace Pizza_Ordering_System
{
    partial class PizzaHut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaHut));
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbLarge = new RadioButton();
            rbMedium = new RadioButton();
            rbSmall = new RadioButton();
            groupBox2 = new GroupBox();
            rbThin = new RadioButton();
            rbThick = new RadioButton();
            groupBox3 = new GroupBox();
            chkGroundedBeef = new CheckBox();
            chkShreddedChicken = new CheckBox();
            chkSpinach = new CheckBox();
            chkDriedShrimp = new CheckBox();
            chkPineapple = new CheckBox();
            chkJalapeno = new CheckBox();
            chkMushroom = new CheckBox();
            chkExtraCheese = new CheckBox();
            chkPepperoni = new CheckBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtTotal = new TextBox();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 32);
            label1.Name = "label1";
            label1.Size = new Size(263, 54);
            label1.TabIndex = 1;
            label1.Text = "Pizza Hut";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(rbLarge);
            groupBox1.Controls.Add(rbMedium);
            groupBox1.Controls.Add(rbSmall);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(3, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 50);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pizza Size";
            // 
            // rbLarge
            // 
            rbLarge.AutoSize = true;
            rbLarge.Location = new Point(245, 22);
            rbLarge.Name = "rbLarge";
            rbLarge.Size = new Size(84, 19);
            rbLarge.TabIndex = 2;
            rbLarge.TabStop = true;
            rbLarge.Text = "Large (R55)";
            rbLarge.UseVisualStyleBackColor = true;
            rbLarge.CheckedChanged += rbLarge_CheckedChanged;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(123, 22);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(100, 19);
            rbMedium.TabIndex = 1;
            rbMedium.TabStop = true;
            rbMedium.Text = "Medium (R35)";
            rbMedium.UseVisualStyleBackColor = true;
            rbMedium.CheckedChanged += rbMedium_CheckedChanged;
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Location = new Point(9, 22);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(84, 19);
            rbSmall.TabIndex = 0;
            rbSmall.TabStop = true;
            rbSmall.Text = "Small (R20)";
            rbSmall.UseVisualStyleBackColor = true;
            rbSmall.CheckedChanged += rbSmall_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbThin);
            groupBox2.Controls.Add(rbThick);
            groupBox2.Location = new Point(3, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 39);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // rbThin
            // 
            rbThin.AutoSize = true;
            rbThin.Location = new Point(188, 14);
            rbThin.Name = "rbThin";
            rbThin.Size = new Size(69, 19);
            rbThin.TabIndex = 1;
            rbThin.TabStop = true;
            rbThin.Text = "Thin(R1)";
            rbThin.UseVisualStyleBackColor = true;
            rbThin.CheckedChanged += rbThin_CheckedChanged;
            // 
            // rbThick
            // 
            rbThick.AutoSize = true;
            rbThick.Location = new Point(69, 14);
            rbThick.Name = "rbThick";
            rbThick.Size = new Size(77, 19);
            rbThick.TabIndex = 0;
            rbThick.TabStop = true;
            rbThick.Text = "Thick (R2)";
            rbThick.UseVisualStyleBackColor = true;
            rbThick.CheckedChanged += rbThick_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkGroundedBeef);
            groupBox3.Controls.Add(chkShreddedChicken);
            groupBox3.Controls.Add(chkSpinach);
            groupBox3.Controls.Add(chkDriedShrimp);
            groupBox3.Controls.Add(chkPineapple);
            groupBox3.Controls.Add(chkJalapeno);
            groupBox3.Controls.Add(chkMushroom);
            groupBox3.Controls.Add(chkExtraCheese);
            groupBox3.Controls.Add(chkPepperoni);
            groupBox3.Location = new Point(3, 251);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(368, 143);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Topping (R7 each)";
            // 
            // chkGroundedBeef
            // 
            chkGroundedBeef.AutoSize = true;
            chkGroundedBeef.Location = new Point(246, 108);
            chkGroundedBeef.Name = "chkGroundedBeef";
            chkGroundedBeef.Size = new Size(105, 19);
            chkGroundedBeef.TabIndex = 8;
            chkGroundedBeef.Text = "Grounded Beef";
            chkGroundedBeef.UseVisualStyleBackColor = true;
            chkGroundedBeef.CheckedChanged += chkGroundedBeef_CheckedChanged;
            // 
            // chkShreddedChicken
            // 
            chkShreddedChicken.AutoSize = true;
            chkShreddedChicken.Location = new Point(246, 68);
            chkShreddedChicken.Name = "chkShreddedChicken";
            chkShreddedChicken.Size = new Size(122, 19);
            chkShreddedChicken.TabIndex = 7;
            chkShreddedChicken.Text = "Shredded Chicken";
            chkShreddedChicken.UseVisualStyleBackColor = true;
            chkShreddedChicken.CheckedChanged += chkShreddedChicken_CheckedChanged;
            // 
            // chkSpinach
            // 
            chkSpinach.AutoSize = true;
            chkSpinach.Location = new Point(246, 31);
            chkSpinach.Name = "chkSpinach";
            chkSpinach.Size = new Size(68, 19);
            chkSpinach.TabIndex = 6;
            chkSpinach.Text = "Spinach";
            chkSpinach.UseVisualStyleBackColor = true;
            chkSpinach.CheckedChanged += chkSpinach_CheckedChanged;
            // 
            // chkDriedShrimp
            // 
            chkDriedShrimp.AutoSize = true;
            chkDriedShrimp.Location = new Point(133, 108);
            chkDriedShrimp.Name = "chkDriedShrimp";
            chkDriedShrimp.Size = new Size(95, 19);
            chkDriedShrimp.TabIndex = 5;
            chkDriedShrimp.Text = "Dried Shrimp";
            chkDriedShrimp.UseVisualStyleBackColor = true;
            chkDriedShrimp.CheckedChanged += chkDriedShrimp_CheckedChanged;
            // 
            // chkPineapple
            // 
            chkPineapple.AutoSize = true;
            chkPineapple.Location = new Point(133, 68);
            chkPineapple.Name = "chkPineapple";
            chkPineapple.Size = new Size(78, 19);
            chkPineapple.TabIndex = 4;
            chkPineapple.Text = "Pineapple";
            chkPineapple.UseVisualStyleBackColor = true;
            chkPineapple.CheckedChanged += chkPineapple_CheckedChanged;
            // 
            // chkJalapeno
            // 
            chkJalapeno.AutoSize = true;
            chkJalapeno.Location = new Point(133, 31);
            chkJalapeno.Name = "chkJalapeno";
            chkJalapeno.Size = new Size(72, 19);
            chkJalapeno.TabIndex = 3;
            chkJalapeno.Text = "Jalapeno";
            chkJalapeno.UseVisualStyleBackColor = true;
            chkJalapeno.CheckedChanged += chkJalapeno_CheckedChanged;
            // 
            // chkMushroom
            // 
            chkMushroom.AutoSize = true;
            chkMushroom.Location = new Point(6, 108);
            chkMushroom.Name = "chkMushroom";
            chkMushroom.Size = new Size(85, 19);
            chkMushroom.TabIndex = 2;
            chkMushroom.Text = "Mushroom";
            chkMushroom.UseVisualStyleBackColor = true;
            chkMushroom.CheckedChanged += chkMushroom_CheckedChanged;
            // 
            // chkExtraCheese
            // 
            chkExtraCheese.AutoSize = true;
            chkExtraCheese.Location = new Point(6, 68);
            chkExtraCheese.Name = "chkExtraCheese";
            chkExtraCheese.Size = new Size(93, 19);
            chkExtraCheese.TabIndex = 1;
            chkExtraCheese.Text = "Extra Cheese";
            chkExtraCheese.UseVisualStyleBackColor = true;
            chkExtraCheese.CheckedChanged += chkExtraCheese_CheckedChanged;
            // 
            // chkPepperoni
            // 
            chkPepperoni.AutoSize = true;
            chkPepperoni.Location = new Point(6, 31);
            chkPepperoni.Name = "chkPepperoni";
            chkPepperoni.Size = new Size(80, 19);
            chkPepperoni.TabIndex = 0;
            chkPepperoni.Text = "Pepperoni";
            chkPepperoni.UseVisualStyleBackColor = true;
            chkPepperoni.CheckedChanged += chkPepperoni_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveBorder;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 417);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 6;
            label2.Text = "Amount Due:  R";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(100, 414);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(299, 413);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(72, 23);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // PizzaHut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(486, 450);
            Controls.Add(btnReset);
            Controls.Add(label2);
            Controls.Add(txtTotal);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "PizzaHut";
            Text = "Pizza Hut";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox pictureBox1;
        private RadioButton rbLarge;
        private RadioButton rbMedium;
        private RadioButton rbSmall;
        private RadioButton rbThin;
        private RadioButton rbThick;
        private Label label2;
        private TextBox txtTotal;
        private Button btnReset;
        private CheckBox chkGroundedBeef;
        private CheckBox chkShreddedChicken;
        private CheckBox chkSpinach;
        private CheckBox chkDriedShrimp;
        private CheckBox chkPineapple;
        private CheckBox chkJalapeno;
        private CheckBox chkMushroom;
        private CheckBox chkExtraCheese;
        private CheckBox chkPepperoni;
        private Label lblTotal;
    }
}