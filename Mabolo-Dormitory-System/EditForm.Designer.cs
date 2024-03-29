namespace Mabolo_Dormitory_System
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.addViewButton = new Guna.UI.WinForms.GunaButton();
            this.closeViewButton = new Guna.UI.WinForms.GunaButton();
            this.chooseCB = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.roomChooseCB = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(-221, -4);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(1096, 10);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 69;
            this.gunaPictureBox1.TabStop = false;
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
            this.addViewButton.Location = new System.Drawing.Point(299, 170);
            this.addViewButton.Name = "addViewButton";
            this.addViewButton.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.addViewButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addViewButton.OnHoverForeColor = System.Drawing.Color.White;
            this.addViewButton.OnHoverImage = null;
            this.addViewButton.OnPressedColor = System.Drawing.Color.Black;
            this.addViewButton.Radius = 10;
            this.addViewButton.Size = new System.Drawing.Size(160, 42);
            this.addViewButton.TabIndex = 71;
            this.addViewButton.Text = "Update";
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
            this.closeViewButton.Location = new System.Drawing.Point(472, 170);
            this.closeViewButton.Name = "closeViewButton";
            this.closeViewButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.closeViewButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.closeViewButton.OnHoverForeColor = System.Drawing.Color.White;
            this.closeViewButton.OnHoverImage = null;
            this.closeViewButton.OnPressedColor = System.Drawing.Color.Black;
            this.closeViewButton.Radius = 10;
            this.closeViewButton.Size = new System.Drawing.Size(160, 42);
            this.closeViewButton.TabIndex = 70;
            this.closeViewButton.Text = "Close";
            this.closeViewButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.closeViewButton.Click += new System.EventHandler(this.closeViewButton_Click);
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
            this.chooseCB.Location = new System.Drawing.Point(134, 56);
            this.chooseCB.Name = "chooseCB";
            this.chooseCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.chooseCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.chooseCB.Size = new System.Drawing.Size(498, 33);
            this.chooseCB.TabIndex = 73;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(21, 22);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(187, 23);
            this.gunaLabel1.TabIndex = 72;
            this.gunaLabel1.Text = "Choose a dormer:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(21, 96);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(216, 23);
            this.gunaLabel2.TabIndex = 74;
            this.gunaLabel2.Text = "Choose a new room:";
            // 
            // roomChooseCB
            // 
            this.roomChooseCB.BackColor = System.Drawing.Color.Transparent;
            this.roomChooseCB.BaseColor = System.Drawing.Color.White;
            this.roomChooseCB.BorderColor = System.Drawing.Color.Silver;
            this.roomChooseCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomChooseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomChooseCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomChooseCB.ForeColor = System.Drawing.Color.Black;
            this.roomChooseCB.FormattingEnabled = true;
            this.roomChooseCB.Location = new System.Drawing.Point(134, 127);
            this.roomChooseCB.Name = "roomChooseCB";
            this.roomChooseCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.roomChooseCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.roomChooseCB.Size = new System.Drawing.Size(211, 33);
            this.roomChooseCB.TabIndex = 75;
            this.roomChooseCB.SelectedIndexChanged += new System.EventHandler(this.roomChooseCB_SelectedIndexChanged);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 224);
            this.Controls.Add(this.roomChooseCB);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.chooseCB);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.addViewButton);
            this.Controls.Add(this.closeViewButton);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpdateForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton addViewButton;
        private Guna.UI.WinForms.GunaButton closeViewButton;
        private Guna.UI.WinForms.GunaComboBox chooseCB;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox roomChooseCB;
    }
}