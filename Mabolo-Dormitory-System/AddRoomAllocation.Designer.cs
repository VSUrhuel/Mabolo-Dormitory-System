namespace Mabolo_Dormitory_System
{
    partial class AddRoomAllocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoomAllocation));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.chooseCB = new Guna.UI.WinForms.GunaComboBox();
            this.addViewButton = new Guna.UI.WinForms.GunaButton();
            this.closeViewButton = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.userTypeCB = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(33, 82);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(321, 23);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Choose a dormer to be added:";
            // 
            // chooseCB
            // 
            this.chooseCB.BackColor = System.Drawing.Color.Transparent;
            this.chooseCB.BaseColor = System.Drawing.Color.White;
            this.chooseCB.BorderColor = System.Drawing.Color.Silver;
            this.chooseCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.chooseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCB.ForeColor = System.Drawing.Color.Black;
            this.chooseCB.FormattingEnabled = true;
            this.chooseCB.Location = new System.Drawing.Point(146, 123);
            this.chooseCB.Name = "chooseCB";
            this.chooseCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chooseCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.chooseCB.Size = new System.Drawing.Size(498, 33);
            this.chooseCB.TabIndex = 1;
            // 
            // addViewButton
            // 
            this.addViewButton.AnimationHoverSpeed = 0.07F;
            this.addViewButton.AnimationSpeed = 0.03F;
            this.addViewButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(62)))));
            this.addViewButton.BorderColor = System.Drawing.Color.Black;
            this.addViewButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addViewButton.ForeColor = System.Drawing.Color.White;
            this.addViewButton.Image = null;
            this.addViewButton.ImageSize = new System.Drawing.Size(20, 20);
            this.addViewButton.Location = new System.Drawing.Point(311, 167);
            this.addViewButton.Name = "addViewButton";
            this.addViewButton.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.addViewButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addViewButton.OnHoverForeColor = System.Drawing.Color.White;
            this.addViewButton.OnHoverImage = null;
            this.addViewButton.OnPressedColor = System.Drawing.Color.Black;
            this.addViewButton.Radius = 10;
            this.addViewButton.Size = new System.Drawing.Size(160, 42);
            this.addViewButton.TabIndex = 67;
            this.addViewButton.Text = "Add";
            this.addViewButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addViewButton.Click += new System.EventHandler(this.addViewButton_Click);
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
            this.closeViewButton.Location = new System.Drawing.Point(484, 167);
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
            this.closeViewButton.Click += new System.EventHandler(this.closeViewButton_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(-237, -3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(1096, 10);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 68;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(33, 38);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(107, 23);
            this.gunaLabel2.TabIndex = 69;
            this.gunaLabel2.Text = "User Type:";
            // 
            // userTypeCB
            // 
            this.userTypeCB.BackColor = System.Drawing.Color.Transparent;
            this.userTypeCB.BaseColor = System.Drawing.Color.White;
            this.userTypeCB.BorderColor = System.Drawing.Color.Silver;
            this.userTypeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.userTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeCB.ForeColor = System.Drawing.Color.Black;
            this.userTypeCB.FormattingEnabled = true;
            this.userTypeCB.Items.AddRange(new object[] {
            "Regular Dormer",
            "Big Brod",
            "Student Assisstant"});
            this.userTypeCB.Location = new System.Drawing.Point(148, 32);
            this.userTypeCB.Name = "userTypeCB";
            this.userTypeCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userTypeCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.userTypeCB.Size = new System.Drawing.Size(208, 33);
            this.userTypeCB.TabIndex = 70;
            this.userTypeCB.SelectedIndexChanged += new System.EventHandler(this.userTypeCB_SelectedIndexChanged);
            // 
            // AddRoomAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 224);
            this.Controls.Add(this.userTypeCB);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.addViewButton);
            this.Controls.Add(this.closeViewButton);
            this.Controls.Add(this.chooseCB);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRoomAllocation";
            this.Text = "AddRoomAllocation";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox chooseCB;
        private Guna.UI.WinForms.GunaButton addViewButton;
        private Guna.UI.WinForms.GunaButton closeViewButton;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox userTypeCB;
    }
}