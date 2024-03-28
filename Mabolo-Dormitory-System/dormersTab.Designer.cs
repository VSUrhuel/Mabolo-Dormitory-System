namespace Mabolo_Dormitory_System
{
    partial class dormersTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dormersTab));
            this.dormerTableView = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.refreshBut = new Guna.UI.WinForms.GunaButton();
            this.itemCB = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.userTypeCB = new Guna.UI.WinForms.GunaComboBox();
            this.searchBar = new Guna.UI.WinForms.GunaLineTextBox();
            this.searchBut = new Guna.UI.WinForms.GunaButton();
            this.addDormerButton = new Guna.UI.WinForms.GunaButton();
            this.deleteBut = new Guna.UI.WinForms.GunaButton();
            this.selectAllCB = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dormerTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // dormerTableView
            // 
            this.dormerTableView.AllowUserToAddRows = false;
            this.dormerTableView.AllowUserToDeleteRows = false;
            this.dormerTableView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dormerTableView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dormerTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dormerTableView.BackgroundColor = System.Drawing.Color.White;
            this.dormerTableView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dormerTableView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dormerTableView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dormerTableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dormerTableView.ColumnHeadersHeight = 52;
            this.dormerTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dormerTableView.DefaultCellStyle = dataGridViewCellStyle9;
            this.dormerTableView.EnableHeadersVisualStyles = false;
            this.dormerTableView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dormerTableView.Location = new System.Drawing.Point(44, 83);
            this.dormerTableView.Name = "dormerTableView";
            this.dormerTableView.RowHeadersVisible = false;
            this.dormerTableView.RowHeadersWidth = 51;
            this.dormerTableView.RowTemplate.Height = 24;
            this.dormerTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dormerTableView.Size = new System.Drawing.Size(1263, 543);
            this.dormerTableView.TabIndex = 1;
            this.dormerTableView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Emerald;
            this.dormerTableView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dormerTableView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dormerTableView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dormerTableView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dormerTableView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dormerTableView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dormerTableView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dormerTableView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dormerTableView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dormerTableView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dormerTableView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dormerTableView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dormerTableView.ThemeStyle.HeaderStyle.Height = 52;
            this.dormerTableView.ThemeStyle.ReadOnly = false;
            this.dormerTableView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dormerTableView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dormerTableView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dormerTableView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dormerTableView.ThemeStyle.RowsStyle.Height = 24;
            this.dormerTableView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dormerTableView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dormerTableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.refreshBut.Location = new System.Drawing.Point(1268, 42);
            this.refreshBut.Name = "refreshBut";
            this.refreshBut.OnHoverBaseColor = System.Drawing.Color.Black;
            this.refreshBut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refreshBut.OnHoverForeColor = System.Drawing.Color.White;
            this.refreshBut.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("refreshBut.OnHoverImage")));
            this.refreshBut.OnPressedColor = System.Drawing.Color.Black;
            this.refreshBut.Radius = 9;
            this.refreshBut.Size = new System.Drawing.Size(39, 36);
            this.refreshBut.TabIndex = 2;
            this.refreshBut.Text = "Refresh";
            this.refreshBut.Click += new System.EventHandler(this.refreshBut_Click);
            // 
            // itemCB
            // 
            this.itemCB.BackColor = System.Drawing.Color.Transparent;
            this.itemCB.BaseColor = System.Drawing.Color.White;
            this.itemCB.BorderColor = System.Drawing.Color.Silver;
            this.itemCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.itemCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCB.ForeColor = System.Drawing.Color.Black;
            this.itemCB.FormattingEnabled = true;
            this.itemCB.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.itemCB.Location = new System.Drawing.Point(1210, 46);
            this.itemCB.Name = "itemCB";
            this.itemCB.OnHoverItemBaseColor = System.Drawing.Color.ForestGreen;
            this.itemCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.itemCB.Radius = 9;
            this.itemCB.Size = new System.Drawing.Size(52, 33);
            this.itemCB.TabIndex = 3;
            this.itemCB.SelectedIndexChanged += new System.EventHandler(this.itemCB_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1156, 52);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(64, 23);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "View:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(797, 52);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(107, 23);
            this.gunaLabel2.TabIndex = 6;
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
            "Student Assistant",
            "Assistant Dorm Adviser",
            "Dorm Adviser",
            "All"});
            this.userTypeCB.Location = new System.Drawing.Point(889, 46);
            this.userTypeCB.Name = "userTypeCB";
            this.userTypeCB.OnHoverItemBaseColor = System.Drawing.Color.ForestGreen;
            this.userTypeCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.userTypeCB.Radius = 9;
            this.userTypeCB.Size = new System.Drawing.Size(239, 33);
            this.userTypeCB.TabIndex = 5;
            this.userTypeCB.SelectedIndexChanged += new System.EventHandler(this.userTypeCB_SelectedIndexChanged);
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.White;
            this.searchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.FocusedLineColor = System.Drawing.Color.ForestGreen;
            this.searchBar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.searchBar.LineSize = 2;
            this.searchBar.Location = new System.Drawing.Point(47, 41);
            this.searchBar.Margin = new System.Windows.Forms.Padding(0);
            this.searchBar.Name = "searchBar";
            this.searchBar.PasswordChar = '\0';
            this.searchBar.Size = new System.Drawing.Size(211, 35);
            this.searchBar.TabIndex = 0;
            this.searchBar.Text = "Search...";
            this.searchBar.TextOffsetX = 10;
            this.searchBar.Click += new System.EventHandler(this.searchBar_Click);
            this.searchBar.Enter += new System.EventHandler(this.searchBar_Enter);
            this.searchBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchBar_MouseClick);
            // 
            // searchBut
            // 
            this.searchBut.AnimationHoverSpeed = 0.07F;
            this.searchBut.AnimationSpeed = 0.03F;
            this.searchBut.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.searchBut.BorderColor = System.Drawing.Color.Black;
            this.searchBut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBut.ForeColor = System.Drawing.Color.White;
            this.searchBut.Image = ((System.Drawing.Image)(resources.GetObject("searchBut.Image")));
            this.searchBut.ImageSize = new System.Drawing.Size(20, 20);
            this.searchBut.Location = new System.Drawing.Point(217, 42);
            this.searchBut.Name = "searchBut";
            this.searchBut.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.searchBut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchBut.OnHoverForeColor = System.Drawing.Color.White;
            this.searchBut.OnHoverImage = null;
            this.searchBut.OnPressedColor = System.Drawing.Color.Black;
            this.searchBut.Size = new System.Drawing.Size(41, 36);
            this.searchBut.TabIndex = 7;
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // addDormerButton
            // 
            this.addDormerButton.AnimationHoverSpeed = 0.07F;
            this.addDormerButton.AnimationSpeed = 0.03F;
            this.addDormerButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.addDormerButton.BorderColor = System.Drawing.Color.White;
            this.addDormerButton.BorderSize = 2;
            this.addDormerButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDormerButton.ForeColor = System.Drawing.Color.White;
            this.addDormerButton.Image = ((System.Drawing.Image)(resources.GetObject("addDormerButton.Image")));
            this.addDormerButton.ImageSize = new System.Drawing.Size(20, 20);
            this.addDormerButton.Location = new System.Drawing.Point(1084, 3);
            this.addDormerButton.Name = "addDormerButton";
            this.addDormerButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.addDormerButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.addDormerButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.addDormerButton.OnHoverImage = null;
            this.addDormerButton.OnPressedColor = System.Drawing.Color.Black;
            this.addDormerButton.Radius = 9;
            this.addDormerButton.Size = new System.Drawing.Size(219, 36);
            this.addDormerButton.TabIndex = 8;
            this.addDormerButton.Text = "Add New Dormer";
            this.addDormerButton.Click += new System.EventHandler(this.addDormerButton_Click);
            // 
            // deleteBut
            // 
            this.deleteBut.AnimationHoverSpeed = 0.07F;
            this.deleteBut.AnimationSpeed = 0.03F;
            this.deleteBut.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.deleteBut.BorderColor = System.Drawing.Color.White;
            this.deleteBut.BorderSize = 2;
            this.deleteBut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBut.ForeColor = System.Drawing.Color.White;
            this.deleteBut.Image = ((System.Drawing.Image)(resources.GetObject("deleteBut.Image")));
            this.deleteBut.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteBut.Location = new System.Drawing.Point(1179, 626);
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.OnHoverBaseColor = System.Drawing.Color.IndianRed;
            this.deleteBut.OnHoverBorderColor = System.Drawing.Color.White;
            this.deleteBut.OnHoverForeColor = System.Drawing.Color.Black;
            this.deleteBut.OnHoverImage = null;
            this.deleteBut.OnPressedColor = System.Drawing.Color.Black;
            this.deleteBut.Radius = 9;
            this.deleteBut.Size = new System.Drawing.Size(128, 32);
            this.deleteBut.TabIndex = 9;
            this.deleteBut.Text = "Delete";
            this.deleteBut.Click += new System.EventHandler(this.deleteBut_Click);
            // 
            // selectAllCB
            // 
            this.selectAllCB.BaseColor = System.Drawing.Color.White;
            this.selectAllCB.CheckedOffColor = System.Drawing.Color.Gray;
            this.selectAllCB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.selectAllCB.FillColor = System.Drawing.Color.White;
            this.selectAllCB.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectAllCB.Location = new System.Drawing.Point(55, 630);
            this.selectAllCB.Name = "selectAllCB";
            this.selectAllCB.Size = new System.Drawing.Size(114, 26);
            this.selectAllCB.TabIndex = 10;
            this.selectAllCB.Text = "Select All";
            this.selectAllCB.CheckedChanged += new System.EventHandler(this.selectAllCB_CheckedChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(51, 3);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(318, 23);
            this.gunaLabel3.TabIndex = 11;
            this.gunaLabel3.Text = "A.Y. 2023 - 2024 | 2nd Semester";
            // 
            // dormersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.selectAllCB);
            this.Controls.Add(this.deleteBut);
            this.Controls.Add(this.addDormerButton);
            this.Controls.Add(this.searchBut);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.userTypeCB);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.itemCB);
            this.Controls.Add(this.refreshBut);
            this.Controls.Add(this.dormerTableView);
            this.Name = "dormersTab";
            this.Size = new System.Drawing.Size(1380, 810);
            ((System.ComponentModel.ISupportInitialize)(this.dormerTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dormerTableView;
        private Guna.UI.WinForms.GunaButton refreshBut;
        private Guna.UI.WinForms.GunaComboBox itemCB;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox userTypeCB;
        private Guna.UI.WinForms.GunaLineTextBox searchBar;
        private Guna.UI.WinForms.GunaButton searchBut;
        private Guna.UI.WinForms.GunaButton addDormerButton;
        private Guna.UI.WinForms.GunaButton deleteBut;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private Guna.UI.WinForms.GunaCheckBox selectAllCB;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}
