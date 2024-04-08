namespace Mabolo_Dormitory_System
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.closeViewButton = new Guna.UI.WinForms.GunaButton();
            this.updatePassButton = new Guna.UI.WinForms.GunaButton();
            this.passwordText = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.confirmPassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.passReview = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.confirmPassText = new Guna.UI.WinForms.GunaLabel();
            this.passReview2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
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
            this.closeViewButton.Location = new System.Drawing.Point(415, 243);
            this.closeViewButton.Name = "closeViewButton";
            this.closeViewButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.closeViewButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.closeViewButton.OnHoverForeColor = System.Drawing.Color.White;
            this.closeViewButton.OnHoverImage = null;
            this.closeViewButton.OnPressedColor = System.Drawing.Color.Black;
            this.closeViewButton.Radius = 10;
            this.closeViewButton.Size = new System.Drawing.Size(103, 33);
            this.closeViewButton.TabIndex = 82;
            this.closeViewButton.Text = "Close";
            this.closeViewButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.closeViewButton.Click += new System.EventHandler(this.closeViewButton_Click);
            // 
            // updatePassButton
            // 
            this.updatePassButton.AnimationHoverSpeed = 0.07F;
            this.updatePassButton.AnimationSpeed = 0.03F;
            this.updatePassButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(62)))));
            this.updatePassButton.BorderColor = System.Drawing.Color.Black;
            this.updatePassButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePassButton.ForeColor = System.Drawing.Color.White;
            this.updatePassButton.Image = null;
            this.updatePassButton.ImageSize = new System.Drawing.Size(20, 20);
            this.updatePassButton.Location = new System.Drawing.Point(297, 243);
            this.updatePassButton.Name = "updatePassButton";
            this.updatePassButton.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.updatePassButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updatePassButton.OnHoverForeColor = System.Drawing.Color.White;
            this.updatePassButton.OnHoverImage = null;
            this.updatePassButton.OnPressedColor = System.Drawing.Color.Black;
            this.updatePassButton.Radius = 10;
            this.updatePassButton.Size = new System.Drawing.Size(103, 33);
            this.updatePassButton.TabIndex = 81;
            this.updatePassButton.Text = "Update";
            this.updatePassButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updatePassButton.Click += new System.EventHandler(this.updatePassButton_Click);
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.White;
            this.passwordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordText.FocusedLineColor = System.Drawing.Color.ForestGreen;
            this.passwordText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.passwordText.Location = new System.Drawing.Point(139, 65);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '\0';
            this.passwordText.Size = new System.Drawing.Size(379, 35);
            this.passwordText.TabIndex = 80;
            this.passwordText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordText_KeyPress);
            this.passwordText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordText_MouseClick);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(98, 29);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(215, 23);
            this.gunaLabel2.TabIndex = 79;
            this.gunaLabel2.Text = "Enter New Password:";
            // 
            // confirmPassword
            // 
            this.confirmPassword.BackColor = System.Drawing.Color.White;
            this.confirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPassword.FocusedLineColor = System.Drawing.Color.ForestGreen;
            this.confirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.confirmPassword.Location = new System.Drawing.Point(139, 177);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '\0';
            this.confirmPassword.Size = new System.Drawing.Size(379, 35);
            this.confirmPassword.TabIndex = 84;
            this.confirmPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.confirmPassword_MouseClick);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(98, 136);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(241, 23);
            this.gunaLabel1.TabIndex = 83;
            this.gunaLabel1.Text = "Confirm New Password:";
            // 
            // passReview
            // 
            this.passReview.AutoSize = true;
            this.passReview.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passReview.ForeColor = System.Drawing.Color.DimGray;
            this.passReview.Location = new System.Drawing.Point(136, 105);
            this.passReview.Name = "passReview";
            this.passReview.Size = new System.Drawing.Size(0, 17);
            this.passReview.TabIndex = 85;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(-330, -3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(1096, 10);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 87;
            this.gunaPictureBox1.TabStop = false;
            // 
            // confirmPassText
            // 
            this.confirmPassText.AutoSize = true;
            this.confirmPassText.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassText.ForeColor = System.Drawing.Color.DimGray;
            this.confirmPassText.Location = new System.Drawing.Point(136, 217);
            this.confirmPassText.Name = "confirmPassText";
            this.confirmPassText.Size = new System.Drawing.Size(0, 17);
            this.confirmPassText.TabIndex = 88;
            // 
            // passReview2
            // 
            this.passReview2.AutoSize = true;
            this.passReview2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passReview2.ForeColor = System.Drawing.Color.DimGray;
            this.passReview2.Location = new System.Drawing.Point(131, 123);
            this.passReview2.Name = "passReview2";
            this.passReview2.Size = new System.Drawing.Size(0, 17);
            this.passReview2.TabIndex = 89;
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
            this.gunaButton2.Location = new System.Drawing.Point(31, 22);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton2.OnHoverImage")));
            this.gunaButton2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.gunaButton2.Radius = 9;
            this.gunaButton2.Size = new System.Drawing.Size(58, 37);
            this.gunaButton2.TabIndex = 141;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.White;
            this.gunaButton1.BorderSize = 2;
            this.gunaButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(31, 127);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton1.OnHoverImage")));
            this.gunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.gunaButton1.Radius = 9;
            this.gunaButton1.Size = new System.Drawing.Size(58, 37);
            this.gunaButton1.TabIndex = 142;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 288);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.passReview2);
            this.Controls.Add(this.confirmPassText);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.passReview);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.closeViewButton);
            this.Controls.Add(this.updatePassButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.gunaLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpdateForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton closeViewButton;
        private Guna.UI.WinForms.GunaButton updatePassButton;
        private Guna.UI.WinForms.GunaLineTextBox passwordText;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox confirmPassword;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel passReview;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel confirmPassText;
        private Guna.UI.WinForms.GunaLabel passReview2;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}