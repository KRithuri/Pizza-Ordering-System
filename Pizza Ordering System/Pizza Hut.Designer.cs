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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbSmall = new RadioButton();
            rbMedium = new RadioButton();
            rbLarge = new RadioButton();
            groupBox2 = new GroupBox();
            rbThick = new RadioButton();
            rbThin = new RadioButton();
            groupBox3 = new GroupBox();
            cbPepperoni = new CheckBox();
            cbExtraCheese = new CheckBox();
            cbMushroom = new CheckBox();
            cbJalapeno = new CheckBox();
            cbPineapple = new CheckBox();
            cbDriedShrimp = new CheckBox();
            cbSpinach = new CheckBox();
            cbShreddedChicken = new CheckBox();
            cbGroundedBeef = new CheckBox();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 23);
            label1.Name = "label1";
            label1.Size = new Size(242, 55);
            label1.TabIndex = 3;
            label1.Text = "Pizza Hut";
            label1.Click += this.label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbLarge);
            groupBox1.Controls.Add(rbMedium);
            groupBox1.Controls.Add(rbSmall);
            groupBox1.Location = new Point(12, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 50);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pizza Size";
            groupBox1.Enter += this.groupBox1_Enter;
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Location = new Point(6, 22);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(84, 19);
            rbSmall.TabIndex = 0;
            rbSmall.TabStop = true;
            rbSmall.Text = "Small (R20)";
            rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            rbMedium.AutoSize = true;
            rbMedium.Location = new Point(153, 22);
            rbMedium.Name = "rbMedium";
            rbMedium.Size = new Size(100, 19);
            rbMedium.TabIndex = 1;
            rbMedium.TabStop = true;
            rbMedium.Text = "Medium (R35)";
            rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            rbLarge.AutoSize = true;
            rbLarge.Location = new Point(289, 22);
            rbLarge.Name = "rbLarge";
            rbLarge.Size = new Size(84, 19);
            rbLarge.TabIndex = 2;
            rbLarge.TabStop = true;
            rbLarge.Text = "Large (R55)";
            rbLarge.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbThin);
            groupBox2.Controls.Add(rbThick);
            groupBox2.Location = new Point(12, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 40);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // rbThick
            // 
            rbThick.AutoSize = true;
            rbThick.Location = new Point(67, 15);
            rbThick.Name = "rbThick";
            rbThick.Size = new Size(77, 19);
            rbThick.TabIndex = 5;
            rbThick.TabStop = true;
            rbThick.Text = "Thick (R2)";
            rbThick.UseVisualStyleBackColor = true;
            // 
            // rbThin
            // 
            rbThin.AutoSize = true;
            rbThin.Location = new Point(184, 15);
            rbThin.Name = "rbThin";
            rbThin.Size = new Size(72, 19);
            rbThin.TabIndex = 6;
            rbThin.TabStop = true;
            rbThin.Text = "Thin (R1)";
            rbThin.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbGroundedBeef);
            groupBox3.Controls.Add(cbShreddedChicken);
            groupBox3.Controls.Add(cbSpinach);
            groupBox3.Controls.Add(cbDriedShrimp);
            groupBox3.Controls.Add(cbPineapple);
            groupBox3.Controls.Add(cbJalapeno);
            groupBox3.Controls.Add(cbMushroom);
            groupBox3.Controls.Add(cbExtraCheese);
            groupBox3.Controls.Add(cbPepperoni);
            groupBox3.Location = new Point(12, 256);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(395, 138);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Topping (R7 each)";
            // 
            // cbPepperoni
            // 
            cbPepperoni.AutoSize = true;
            cbPepperoni.Location = new Point(6, 31);
            cbPepperoni.Name = "cbPepperoni";
            cbPepperoni.Size = new Size(80, 19);
            cbPepperoni.TabIndex = 0;
            cbPepperoni.Text = "Pepperoni";
            cbPepperoni.UseVisualStyleBackColor = true;
            // 
            // cbExtraCheese
            // 
            cbExtraCheese.AutoSize = true;
            cbExtraCheese.Location = new Point(6, 73);
            cbExtraCheese.Name = "cbExtraCheese";
            cbExtraCheese.Size = new Size(93, 19);
            cbExtraCheese.TabIndex = 1;
            cbExtraCheese.Text = "Extra Cheese";
            cbExtraCheese.UseVisualStyleBackColor = true;
            cbExtraCheese.CheckedChanged += this.checkBox2_CheckedChanged;
            // 
            // cbMushroom
            // 
            cbMushroom.AutoSize = true;
            cbMushroom.Location = new Point(6, 113);
            cbMushroom.Name = "cbMushroom";
            cbMushroom.Size = new Size(85, 19);
            cbMushroom.TabIndex = 2;
            cbMushroom.Text = "Mushroom";
            cbMushroom.UseVisualStyleBackColor = true;
            // 
            // cbJalapeno
            // 
            cbJalapeno.AutoSize = true;
            cbJalapeno.Location = new Point(131, 31);
            cbJalapeno.Name = "cbJalapeno";
            cbJalapeno.Size = new Size(72, 19);
            cbJalapeno.TabIndex = 3;
            cbJalapeno.Text = "Jalapeno";
            cbJalapeno.UseVisualStyleBackColor = true;
            // 
            // cbPineapple
            // 
            cbPineapple.AutoSize = true;
            cbPineapple.Location = new Point(131, 73);
            cbPineapple.Name = "cbPineapple";
            cbPineapple.Size = new Size(78, 19);
            cbPineapple.TabIndex = 4;
            cbPineapple.Text = "Pineapple";
            cbPineapple.UseVisualStyleBackColor = true;
            // 
            // cbDriedShrimp
            // 
            cbDriedShrimp.AutoSize = true;
            cbDriedShrimp.Location = new Point(131, 113);
            cbDriedShrimp.Name = "cbDriedShrimp";
            cbDriedShrimp.Size = new Size(95, 19);
            cbDriedShrimp.TabIndex = 5;
            cbDriedShrimp.Text = "Dried Shrimp";
            cbDriedShrimp.UseVisualStyleBackColor = true;
            // 
            // cbSpinach
            // 
            cbSpinach.AutoSize = true;
            cbSpinach.Location = new Point(270, 31);
            cbSpinach.Name = "cbSpinach";
            cbSpinach.Size = new Size(68, 19);
            cbSpinach.TabIndex = 6;
            cbSpinach.Text = "Spinach";
            cbSpinach.UseVisualStyleBackColor = true;
            // 
            // cbShreddedChicken
            // 
            cbShreddedChicken.AutoSize = true;
            cbShreddedChicken.Location = new Point(270, 73);
            cbShreddedChicken.Name = "cbShreddedChicken";
            cbShreddedChicken.Size = new Size(122, 19);
            cbShreddedChicken.TabIndex = 7;
            cbShreddedChicken.Text = "Shredded Chicken";
            cbShreddedChicken.UseVisualStyleBackColor = true;
            // 
            // cbGroundedBeef
            // 
            cbGroundedBeef.AutoSize = true;
            cbGroundedBeef.Location = new Point(270, 113);
            cbGroundedBeef.Name = "cbGroundedBeef";
            cbGroundedBeef.Size = new Size(105, 19);
            cbGroundedBeef.TabIndex = 8;
            cbGroundedBeef.Text = "Grounded Beef";
            cbGroundedBeef.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 416);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 6;
            label2.Text = "Amount Due:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 413);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(92, 23);
            textBox1.TabIndex = 7;
            // 
            // PizzaHut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 450);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "PizzaHut";
            Text = "Pizza Hut";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbSmall;
        private RadioButton rbLarge;
        private RadioButton rbMedium;
        private GroupBox groupBox2;
        private RadioButton rbThin;
        private RadioButton rbThick;
        private GroupBox groupBox3;
        private CheckBox cbGroundedBeef;
        private CheckBox cbShreddedChicken;
        private CheckBox cbSpinach;
        private CheckBox cbDriedShrimp;
        private CheckBox cbPineapple;
        private CheckBox cbJalapeno;
        private CheckBox cbMushroom;
        private CheckBox cbExtraCheese;
        private CheckBox cbPepperoni;
        private Label label2;
        private TextBox textBox1;
    }
}