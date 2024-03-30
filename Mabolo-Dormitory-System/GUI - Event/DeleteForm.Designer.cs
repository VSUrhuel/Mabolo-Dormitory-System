namespace Mabolo_Dormitory_System.GUI___Event
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.deleteButton = new Guna.UI.WinForms.GunaButton();
            this.closeViewButton = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(-261, -1);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(1096, 10);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 4;
            this.gunaPictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(428, 31);
            this.comboBox1.TabIndex = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(12, 31);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(76, 23);
            this.gunaLabel2.TabIndex = 35;
            this.gunaLabel2.Text = "Select:";
            // 
            // deleteButton
            // 
            this.deleteButton.AnimationHoverSpeed = 0.07F;
            this.deleteButton.AnimationSpeed = 0.03F;
            this.deleteButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(62)))));
            this.deleteButton.BorderColor = System.Drawing.Color.Black;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = null;
            this.deleteButton.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteButton.Location = new System.Drawing.Point(145, 125);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.deleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteButton.OnHoverImage = null;
            this.deleteButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteButton.Radius = 10;
            this.deleteButton.Size = new System.Drawing.Size(160, 42);
            this.deleteButton.TabIndex = 67;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.closeViewButton.Location = new System.Drawing.Point(318, 125);
            this.closeViewButton.Name = "closeViewButton";
            this.closeViewButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.closeViewButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.closeViewButton.OnHoverForeColor = System.Drawing.Color.White;
            this.closeViewButton.OnHoverImage = null;
            this.closeViewButton.OnPressedColor = System.Drawing.Color.Black;
            this.closeViewButton.Radius = 10;
            this.closeViewButton.Size = new System.Drawing.Size(160, 42);
            this.closeViewButton.TabIndex = 66;
            this.closeViewButton.Text = "Close";
            this.closeViewButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 189);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.closeViewButton);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton deleteButton;
        private Guna.UI.WinForms.GunaButton closeViewButton;
    }
}