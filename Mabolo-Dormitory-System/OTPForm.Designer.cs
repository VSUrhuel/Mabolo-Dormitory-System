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
            this.otpCodeTB = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
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
            this.closeViewButton.Location = new System.Drawing.Point(267, 75);
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
            this.verifyViewButton.Location = new System.Drawing.Point(158, 75);
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
            // otpCodeTB
            // 
            this.otpCodeTB.BackColor = System.Drawing.Color.White;
            this.otpCodeTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.otpCodeTB.FocusedLineColor = System.Drawing.Color.ForestGreen;
            this.otpCodeTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otpCodeTB.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.otpCodeTB.Location = new System.Drawing.Point(210, 20);
            this.otpCodeTB.Name = "otpCodeTB";
            this.otpCodeTB.PasswordChar = '\0';
            this.otpCodeTB.Size = new System.Drawing.Size(160, 35);
            this.otpCodeTB.TabIndex = 76;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(35, 26);
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
            // OTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 123);
            this.Controls.Add(this.closeViewButton);
            this.Controls.Add(this.verifyViewButton);
            this.Controls.Add(this.otpCodeTB);
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
        private Guna.UI.WinForms.GunaLineTextBox otpCodeTB;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}