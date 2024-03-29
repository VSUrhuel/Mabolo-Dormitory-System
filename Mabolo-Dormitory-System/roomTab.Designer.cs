namespace Mabolo_Dormitory_System
{
    partial class roomTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roomTab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.selectAllCB = new Guna.UI.WinForms.GunaCheckBox();
            this.editButton = new Guna.UI.WinForms.GunaButton();
            this.add1 = new Guna.UI.WinForms.GunaButton();
            this.delBut = new Guna.UI.WinForms.GunaButton();
            this.refreshBut = new Guna.UI.WinForms.GunaButton();
            this.roomUserView = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomChooseCB = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomUserView)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.selectAllCB);
            this.gunaElipsePanel1.Controls.Add(this.editButton);
            this.gunaElipsePanel1.Controls.Add(this.add1);
            this.gunaElipsePanel1.Controls.Add(this.delBut);
            this.gunaElipsePanel1.Controls.Add(this.refreshBut);
            this.gunaElipsePanel1.Controls.Add(this.roomUserView);
            this.gunaElipsePanel1.Controls.Add(this.roomChooseCB);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(39, 4);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1268, 647);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // selectAllCB
            // 
            this.selectAllCB.BaseColor = System.Drawing.Color.White;
            this.selectAllCB.CheckedOffColor = System.Drawing.Color.Gray;
            this.selectAllCB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.selectAllCB.FillColor = System.Drawing.Color.White;
            this.selectAllCB.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectAllCB.Location = new System.Drawing.Point(17, 53);
            this.selectAllCB.Name = "selectAllCB";
            this.selectAllCB.Size = new System.Drawing.Size(114, 26);
            this.selectAllCB.TabIndex = 18;
            this.selectAllCB.Text = "Select All";
            this.selectAllCB.CheckedChanged += new System.EventHandler(this.selectAllCB_CheckedChanged);
            // 
            // editButton
            // 
            this.editButton.AnimationHoverSpeed = 0.07F;
            this.editButton.AnimationSpeed = 0.03F;
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.BaseColor = System.Drawing.Color.Transparent;
            this.editButton.BorderColor = System.Drawing.Color.Transparent;
            this.editButton.BorderSize = 1;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageSize = new System.Drawing.Size(20, 20);
            this.editButton.Location = new System.Drawing.Point(1094, 43);
            this.editButton.Name = "editButton";
            this.editButton.OnHoverBaseColor = System.Drawing.Color.Black;
            this.editButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.editButton.OnHoverForeColor = System.Drawing.Color.White;
            this.editButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("editButton.OnHoverImage")));
            this.editButton.OnPressedColor = System.Drawing.Color.Black;
            this.editButton.Radius = 9;
            this.editButton.Size = new System.Drawing.Size(39, 36);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Refresh";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // add1
            // 
            this.add1.AnimationHoverSpeed = 0.07F;
            this.add1.AnimationSpeed = 0.03F;
            this.add1.BackColor = System.Drawing.Color.Transparent;
            this.add1.BaseColor = System.Drawing.Color.Transparent;
            this.add1.BorderColor = System.Drawing.Color.Transparent;
            this.add1.BorderSize = 1;
            this.add1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add1.Image = ((System.Drawing.Image)(resources.GetObject("add1.Image")));
            this.add1.ImageSize = new System.Drawing.Size(20, 20);
            this.add1.Location = new System.Drawing.Point(1134, 43);
            this.add1.Name = "add1";
            this.add1.OnHoverBaseColor = System.Drawing.Color.Black;
            this.add1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.add1.OnHoverForeColor = System.Drawing.Color.White;
            this.add1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("add1.OnHoverImage")));
            this.add1.OnPressedColor = System.Drawing.Color.Black;
            this.add1.Radius = 9;
            this.add1.Size = new System.Drawing.Size(39, 36);
            this.add1.TabIndex = 16;
            this.add1.Text = "Refresh";
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // delBut
            // 
            this.delBut.AnimationHoverSpeed = 0.07F;
            this.delBut.AnimationSpeed = 0.03F;
            this.delBut.BackColor = System.Drawing.Color.Transparent;
            this.delBut.BaseColor = System.Drawing.Color.Transparent;
            this.delBut.BorderColor = System.Drawing.Color.Transparent;
            this.delBut.BorderSize = 1;
            this.delBut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delBut.Image = ((System.Drawing.Image)(resources.GetObject("delBut.Image")));
            this.delBut.ImageSize = new System.Drawing.Size(20, 20);
            this.delBut.Location = new System.Drawing.Point(1175, 43);
            this.delBut.Name = "delBut";
            this.delBut.OnHoverBaseColor = System.Drawing.Color.Black;
            this.delBut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.delBut.OnHoverForeColor = System.Drawing.Color.White;
            this.delBut.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("delBut.OnHoverImage")));
            this.delBut.OnPressedColor = System.Drawing.Color.Black;
            this.delBut.Radius = 9;
            this.delBut.Size = new System.Drawing.Size(39, 36);
            this.delBut.TabIndex = 13;
            this.delBut.Text = "Refresh";
            this.delBut.Click += new System.EventHandler(this.delBut_Click);
            // 
            // refreshBut
            // 
            this.refreshBut.AnimationHoverSpeed = 0.07F;
            this.refreshBut.AnimationSpeed = 0.03F;
            this.refreshBut.BackColor = System.Drawing.Color.Transparent;
            this.refreshBut.BaseColor = System.Drawing.Color.Transparent;
            this.refreshBut.BorderColor = System.Drawing.Color.Transparent;
            this.refreshBut.BorderSize = 1;
            this.refreshBut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshBut.Image = ((System.Drawing.Image)(resources.GetObject("refreshBut.Image")));
            this.refreshBut.ImageSize = new System.Drawing.Size(20, 20);
            this.refreshBut.Location = new System.Drawing.Point(1215, 43);
            this.refreshBut.Name = "refreshBut";
            this.refreshBut.OnHoverBaseColor = System.Drawing.Color.Black;
            this.refreshBut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refreshBut.OnHoverForeColor = System.Drawing.Color.White;
            this.refreshBut.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("refreshBut.OnHoverImage")));
            this.refreshBut.OnPressedColor = System.Drawing.Color.Black;
            this.refreshBut.Radius = 9;
            this.refreshBut.Size = new System.Drawing.Size(39, 36);
            this.refreshBut.TabIndex = 6;
            this.refreshBut.Text = "Refresh";
            this.refreshBut.Click += new System.EventHandler(this.refreshBut_Click);
            // 
            // roomUserView
            // 
            this.roomUserView.AllowUserToAddRows = false;
            this.roomUserView.AllowUserToDeleteRows = false;
            this.roomUserView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.roomUserView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.roomUserView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomUserView.BackgroundColor = System.Drawing.Color.White;
            this.roomUserView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomUserView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.roomUserView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomUserView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.roomUserView.ColumnHeadersHeight = 52;
            this.roomUserView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomUserView.DefaultCellStyle = dataGridViewCellStyle3;
            this.roomUserView.EnableHeadersVisualStyles = false;
            this.roomUserView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.roomUserView.Location = new System.Drawing.Point(3, 85);
            this.roomUserView.Name = "roomUserView";
            this.roomUserView.RowHeadersVisible = false;
            this.roomUserView.RowHeadersWidth = 51;
            this.roomUserView.RowTemplate.Height = 24;
            this.roomUserView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomUserView.Size = new System.Drawing.Size(1263, 512);
            this.roomUserView.TabIndex = 2;
            this.roomUserView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Emerald;
            this.roomUserView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.roomUserView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.roomUserView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.roomUserView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.roomUserView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.roomUserView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.roomUserView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.roomUserView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.roomUserView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.roomUserView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.roomUserView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.roomUserView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.roomUserView.ThemeStyle.HeaderStyle.Height = 52;
            this.roomUserView.ThemeStyle.ReadOnly = false;
            this.roomUserView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.roomUserView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.roomUserView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.roomUserView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.roomUserView.ThemeStyle.RowsStyle.Height = 24;
            this.roomUserView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.roomUserView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.roomUserView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomUserView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.roomChooseCB.Location = new System.Drawing.Point(172, 11);
            this.roomChooseCB.Name = "roomChooseCB";
            this.roomChooseCB.OnHoverItemBaseColor = System.Drawing.Color.ForestGreen;
            this.roomChooseCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.roomChooseCB.Radius = 9;
            this.roomChooseCB.Size = new System.Drawing.Size(160, 33);
            this.roomChooseCB.TabIndex = 1;
            this.roomChooseCB.SelectedIndexChanged += new System.EventHandler(this.roomChooseCB_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(13, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(173, 23);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Choose a Room:";
            // 
            // roomTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "roomTab";
            this.Size = new System.Drawing.Size(1380, 810);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomUserView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaComboBox roomChooseCB;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDataGridView roomUserView;
        private Guna.UI.WinForms.GunaButton refreshBut;
        private Guna.UI.WinForms.GunaButton add1;
        private Guna.UI.WinForms.GunaButton delBut;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private Guna.UI.WinForms.GunaButton editButton;
        private Guna.UI.WinForms.GunaCheckBox selectAllCB;
    }
}
