namespace Mabolo_Dormitory_System
{
    partial class RoomReallocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomReallocation));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.updateReallocButton = new Guna.UI.WinForms.GunaButton();
            this.closeReallocButton = new Guna.UI.WinForms.GunaButton();
            this.chooseCB = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.roomChooseCB = new Guna.UI.WinForms.GunaComboBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
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
            // updateReallocButton
            // 
            this.updateReallocButton.AnimationHoverSpeed = 0.07F;
            this.updateReallocButton.AnimationSpeed = 0.03F;
            this.updateReallocButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(62)))));
            this.updateReallocButton.BorderColor = System.Drawing.Color.Black;
            this.updateReallocButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateReallocButton.ForeColor = System.Drawing.Color.White;
            this.updateReallocButton.Image = null;
            this.updateReallocButton.ImageSize = new System.Drawing.Size(20, 20);
            this.updateReallocButton.Location = new System.Drawing.Point(297, 249);
            this.updateReallocButton.Name = "updateReallocButton";
            this.updateReallocButton.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.updateReallocButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateReallocButton.OnHoverForeColor = System.Drawing.Color.White;
            this.updateReallocButton.OnHoverImage = null;
            this.updateReallocButton.OnPressedColor = System.Drawing.Color.Black;
            this.updateReallocButton.Radius = 10;
            this.updateReallocButton.Size = new System.Drawing.Size(160, 42);
            this.updateReallocButton.TabIndex = 71;
            this.updateReallocButton.Text = "Update";
            this.updateReallocButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateReallocButton.Click += new System.EventHandler(this.updateReallocButton_Click);
            // 
            // closeReallocButton
            // 
            this.closeReallocButton.AnimationHoverSpeed = 0.07F;
            this.closeReallocButton.AnimationSpeed = 0.03F;
            this.closeReallocButton.BaseColor = System.Drawing.Color.IndianRed;
            this.closeReallocButton.BorderColor = System.Drawing.Color.Black;
            this.closeReallocButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeReallocButton.ForeColor = System.Drawing.Color.White;
            this.closeReallocButton.Image = null;
            this.closeReallocButton.ImageSize = new System.Drawing.Size(20, 20);
            this.closeReallocButton.Location = new System.Drawing.Point(470, 249);
            this.closeReallocButton.Name = "closeReallocButton";
            this.closeReallocButton.OnHoverBaseColor = System.Drawing.Color.Red;
            this.closeReallocButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.closeReallocButton.OnHoverForeColor = System.Drawing.Color.White;
            this.closeReallocButton.OnHoverImage = null;
            this.closeReallocButton.OnPressedColor = System.Drawing.Color.Black;
            this.closeReallocButton.Radius = 10;
            this.closeReallocButton.Size = new System.Drawing.Size(160, 42);
            this.closeReallocButton.TabIndex = 70;
            this.closeReallocButton.Text = "Close";
            this.closeReallocButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.closeReallocButton.Click += new System.EventHandler(this.closeReallocButton_Click);
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
            this.chooseCB.Location = new System.Drawing.Point(134, 118);
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
            this.gunaLabel1.Location = new System.Drawing.Point(89, 82);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(187, 23);
            this.gunaLabel1.TabIndex = 72;
            this.gunaLabel1.Text = "Choose a dormer:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(89, 163);
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
            this.roomChooseCB.Location = new System.Drawing.Point(134, 201);
            this.roomChooseCB.Name = "roomChooseCB";
            this.roomChooseCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.roomChooseCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.roomChooseCB.Size = new System.Drawing.Size(211, 33);
            this.roomChooseCB.TabIndex = 75;
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
            this.gunaButton2.Location = new System.Drawing.Point(25, 156);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton2.OnHoverImage")));
            this.gunaButton2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.gunaButton2.Radius = 9;
            this.gunaButton2.Size = new System.Drawing.Size(58, 37);
            this.gunaButton2.TabIndex = 144;
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
            this.gunaButton1.Location = new System.Drawing.Point(25, 74);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton1.OnHoverImage")));
            this.gunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.gunaButton1.Radius = 9;
            this.gunaButton1.Size = new System.Drawing.Size(58, 37);
            this.gunaButton1.TabIndex = 143;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(194, 19);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(320, 34);
            this.gunaLabel3.TabIndex = 142;
            this.gunaLabel3.Text = "ROOM REALLOCATION";
            // 
            // RoomReallocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 312);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.roomChooseCB);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.chooseCB);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.updateReallocButton);
            this.Controls.Add(this.closeReallocButton);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoomReallocation";
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
        private Guna.UI.WinForms.GunaButton updateReallocButton;
        private Guna.UI.WinForms.GunaButton closeReallocButton;
        private Guna.UI.WinForms.GunaComboBox chooseCB;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox roomChooseCB;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}