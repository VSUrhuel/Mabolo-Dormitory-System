namespace Mabolo_Dormitory_System
{
    partial class OTPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTPForm));
            this.closeViewButton = new Guna.UI.WinForms.GunaButton();
            this.verifyViewButton = new Guna.UI.WinForms.GunaButton();
            this.tb1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.tb2 = new Guna.UI.WinForms.GunaLineTextBox();
            this.tb3 = new Guna.UI.WinForms.GunaLineTextBox();
            this.tb4 = new Guna.UI.WinForms.GunaLineTextBox();
            this.tb6 = new Guna.UI.WinForms.GunaLineTextBox();
            this.tb5 = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeViewButton
            // 
            this.closeViewButton.AnimationHoverSpeed = 0.07F;
            this.closeViewButton.AnimationSpeed = 0.03F;
            this.closeViewButton.BaseColor = System.Drawing.Color.IndianRed;
            this.closeViewButton.BorderColor = System.Drawing.Color.Black;
            this.closeViewButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeViewButton.ForeColor = System.Drawing.Color.White;
            this.closeViewButton.Image = null;
            this.closeViewButton.ImageSize = new System.Drawing.Size(20, 20);
            this.closeViewButton.Location = new System.Drawing.Point(318, 128);
            this.closeViewButton.Name = "closeViewButton";
            this.closeViewButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.closeViewButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.closeViewButton.OnHoverForeColor = System.Drawing.Color.White;
            this.closeViewButton.OnHoverImage = null;
            this.closeViewButton.OnPressedColor = System.Drawing.Color.Black;
            this.closeViewButton.Radius = 10;
            this.closeViewButton.Size = new System.Drawing.Size(103, 33);
            this.closeViewButton.TabIndex = 78;
            this.closeViewButton.Text = "Close";
            this.closeViewButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.closeViewButton.Click += new System.EventHandler(this.closeViewButton_Click);
            // 
            // verifyViewButton
            // 
            this.verifyViewButton.AnimationHoverSpeed = 0.07F;
            this.verifyViewButton.AnimationSpeed = 0.03F;
            this.verifyViewButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(62)))));
            this.verifyViewButton.BorderColor = System.Drawing.Color.Black;
            this.verifyViewButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyViewButton.ForeColor = System.Drawing.Color.White;
            this.verifyViewButton.Image = null;
            this.verifyViewButton.ImageSize = new System.Drawing.Size(20, 20);
            this.verifyViewButton.Location = new System.Drawing.Point(209, 128);
            this.verifyViewButton.Name = "verifyViewButton";
            this.verifyViewButton.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.verifyViewButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.verifyViewButton.OnHoverForeColor = System.Drawing.Color.White;
            this.verifyViewButton.OnHoverImage = null;
            this.verifyViewButton.OnPressedColor = System.Drawing.Color.Black;
            this.verifyViewButton.Radius = 10;
            this.verifyViewButton.Size = new System.Drawing.Size(103, 33);
            this.verifyViewButton.TabIndex = 77;
            this.verifyViewButton.Text = "Verify";
            this.verifyViewButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verifyViewButton.Click += new System.EventHandler(this.verifyViewButton_Click);
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.White;
            this.tb1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb1.FocusedLineColor = System.Drawing.Color.ForestGreen;
            this.tb1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.tb1.Location = new System.Drawing.Point(71, 65);
            this.tb1.MaxLength = 1;
            this.tb1.Name = "tb1";
            this.tb1.PasswordChar = '\0';
            this.tb1.Size = new System.Drawing.Size(38, 39);
            this.tb1.TabIndex = 76;
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(67, 25);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(169, 23);
            this.gunaLabel2.TabIndex = 75;
            this.gunaLabel2.Text = "Enter OTP Code:";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(-312, -2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(1096, 10);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 74;
            this.gunaPictureBox1.TabStop = false;
            // 
            // tb2
            // 
            this.tb2.BackColor = System.Drawing.Color.White;
            this.tb2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb2.FocusedLineColor = System.Drawing.Color.ForestGreen;
            this.tb2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.tb2.Location = new System.Drawing.Point(132, 65);
            this.tb2.MaxLength = 1;
            this.tb2.Name = "tb2";
            this.tb2.PasswordChar = '\0';
            this.tb2.Size = new System.Drawing.Size(38, 39);
            this.tb2.TabIndex = 79;
            this.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb3
            // 
            this.tb3.BackColor = System.Drawing.Color.White;
            this.tb3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb3.FocusedLineColor = System.Drawing.Color.ForestGreen;
            this.tb3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.tb3.Location = new System.Drawing.Point(192, 65);
            this.tb3.MaxLength = 1;
            this.tb3.Name = "tb3";
            this.tb3.PasswordChar = '\0';
            this.tb3.Size = new System.Drawing.Size(38, 39);
            this.tb3.TabIndex = 80;
            this.tb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb4
            // 
            this.tb4.BackColor = System.Drawing.Color.White;
            this.tb4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb4.FocusedLineColor = System.Drawing.Color.ForestGreen;
            this.tb4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.tb4.Location = new System.Drawing.Point(254, 65);
            this.tb4.MaxLength = 1;
            this.tb4.Name = "tb4";
            this.tb4.PasswordChar = '\0';
            this.tb4.Size = new System.Drawing.Size(38, 39);
            this.tb4.TabIndex = 81;
            this.tb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb6
            // 
            this.tb6.BackColor = System.Drawing.Color.White;
            this.tb6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb6.FocusedLineColor = System.Drawing.Color.ForestGreen;
            this.tb6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.tb6.Location = new System.Drawing.Point(383, 65);
            this.tb6.MaxLength = 1;
            this.tb6.Name = "tb6";
            this.tb6.PasswordChar = '\0';
            this.tb6.Size = new System.Drawing.Size(38, 39);
            this.tb6.TabIndex = 83;
            this.tb6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb5
            // 
            this.tb5.BackColor = System.Drawing.Color.White;
            this.tb5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb5.FocusedLineColor = System.Drawing.Color.ForestGreen;
            this.tb5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.tb5.Location = new System.Drawing.Point(321, 65);
            this.tb5.MaxLength = 1;
            this.tb5.Name = "tb5";
            this.tb5.PasswordChar = '\0';
            this.tb5.Size = new System.Drawing.Size(38, 39);
            this.tb5.TabIndex = 82;
            this.tb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.White;
            this.gunaButton2.BorderSize = 2;
            this.gunaButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(6, 17);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton2.OnHoverImage")));
            this.gunaButton2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.gunaButton2.Radius = 9;
            this.gunaButton2.Size = new System.Drawing.Size(58, 37);
            this.gunaButton2.TabIndex = 140;
            
            // 
            // OTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 178);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.closeViewButton);
            this.Controls.Add(this.verifyViewButton);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OTPForm";
            this.Text = "OTPForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpdateForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton closeViewButton;
        private Guna.UI.WinForms.GunaButton verifyViewButton;
        private Guna.UI.WinForms.GunaLineTextBox tb1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLineTextBox tb2;
        private Guna.UI.WinForms.GunaLineTextBox tb3;
        private Guna.UI.WinForms.GunaLineTextBox tb4;
        private Guna.UI.WinForms.GunaLineTextBox tb6;
        private Guna.UI.WinForms.GunaLineTextBox tb5;
        private Guna.UI.WinForms.GunaButton gunaButton2;
    }
}