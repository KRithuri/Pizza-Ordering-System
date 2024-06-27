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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            rbSmall = new RadioButton();
            rbMedium = new RadioButton();
            rbLarge = new RadioButton();
            rbThick = new RadioButton();
            rbThin = new RadioButton();
            label2 = new Label();
            txtTotal = new TextBox();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox1.Controls.Add(rbLarge);
            groupBox1.Controls.Add(rbMedium);
            groupBox1.Controls.Add(rbSmall);
            groupBox1.Location = new Point(3, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 50);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pizza Size";
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
            // groupBox3
            // 
            groupBox3.Location = new Point(3, 251);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(368, 143);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Topping (R7 each)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 417);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 6;
            label2.Text = "Amount Due: R";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(119, 410);
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
    }
}