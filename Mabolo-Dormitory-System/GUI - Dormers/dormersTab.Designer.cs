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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dormersTab));
            this.dormerTableView = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.refreshButton = new Guna.UI.WinForms.GunaButton();
            this.viewCountCB = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.userTypeCB = new Guna.UI.WinForms.GunaComboBox();
            this.searchBar = new Guna.UI.WinForms.GunaLineTextBox();
            this.searchButton = new Guna.UI.WinForms.GunaButton();
            this.addDormerButton = new Guna.UI.WinForms.GunaButton();
            this.selectAllCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.deleteButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.moveNextPage = new Guna.UI.WinForms.GunaImageButton();
            this.movePrevPage = new Guna.UI.WinForms.GunaImageButton();
            this.over = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.count = new Guna.UI.WinForms.GunaLabel();
            this.printButton = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dormerTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // dormerTableView
            // 
            this.dormerTableView.AllowUserToAddRows = false;
            this.dormerTableView.AllowUserToDeleteRows = false;
            this.dormerTableView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dormerTableView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dormerTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dormerTableView.BackgroundColor = System.Drawing.Color.White;
            this.dormerTableView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dormerTableView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dormerTableView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dormerTableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dormerTableView.ColumnHeadersHeight = 52;
            this.dormerTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dormerTableView.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.dormerTableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dormerTableView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // refreshButton
            // 
            this.refreshButton.AnimationHoverSpeed = 0.07F;
            this.refreshButton.AnimationSpeed = 0.03F;
            this.refreshButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshButton.BaseColor = System.Drawing.Color.Transparent;
            this.refreshButton.BorderColor = System.Drawing.Color.Transparent;
            this.refreshButton.BorderSize = 1;
            this.refreshButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageSize = new System.Drawing.Size(20, 20);
            this.refreshButton.Location = new System.Drawing.Point(1268, 42);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.OnHoverBaseColor = System.Drawing.Color.Black;
            this.refreshButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refreshButton.OnHoverForeColor = System.Drawing.Color.White;
            this.refreshButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.OnHoverImage")));
            this.refreshButton.OnPressedColor = System.Drawing.Color.Black;
            this.refreshButton.Radius = 9;
            this.refreshButton.Size = new System.Drawing.Size(39, 36);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButtton_Click);
            // 
            // viewCountCB
            // 
            this.viewCountCB.BackColor = System.Drawing.Color.Transparent;
            this.viewCountCB.BaseColor = System.Drawing.Color.White;
            this.viewCountCB.BorderColor = System.Drawing.Color.Silver;
            this.viewCountCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.viewCountCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewCountCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCountCB.ForeColor = System.Drawing.Color.Black;
            this.viewCountCB.FormattingEnabled = true;
            this.viewCountCB.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.viewCountCB.Location = new System.Drawing.Point(1161, 46);
            this.viewCountCB.Name = "viewCountCB";
            this.viewCountCB.OnHoverItemBaseColor = System.Drawing.Color.ForestGreen;
            this.viewCountCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.viewCountCB.Radius = 9;
            this.viewCountCB.Size = new System.Drawing.Size(52, 33);
            this.viewCountCB.TabIndex = 3;
            this.viewCountCB.SelectedIndexChanged += new System.EventHandler(this.viewCountCB_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1107, 52);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(64, 23);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "View:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(748, 52);
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
            "Assistant Dormitory Adviser",
            "Dormitory Adviser",
            "All"});
            this.userTypeCB.Location = new System.Drawing.Point(840, 46);
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
            // 
            // searchButton
            // 
            this.searchButton.AnimationHoverSpeed = 0.07F;
            this.searchButton.AnimationSpeed = 0.03F;
            this.searchButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.searchButton.BorderColor = System.Drawing.Color.Black;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageSize = new System.Drawing.Size(20, 20);
            this.searchButton.Location = new System.Drawing.Point(217, 42);
            this.searchButton.Name = "searchButton";
            this.searchButton.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.searchButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchButton.OnHoverForeColor = System.Drawing.Color.White;
            this.searchButton.OnHoverImage = null;
            this.searchButton.OnPressedColor = System.Drawing.Color.Black;
            this.searchButton.Size = new System.Drawing.Size(41, 36);
            this.searchButton.TabIndex = 7;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addDormerButton
            // 
            this.addDormerButton.AnimationHoverSpeed = 0.07F;
            this.addDormerButton.AnimationSpeed = 0.03F;
            this.addDormerButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.addDormerButton.BorderColor = System.Drawing.Color.White;
            this.addDormerButton.BorderSize = 2;
            this.addDormerButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDormerButton.ForeColor = System.Drawing.Color.White;
            this.addDormerButton.Image = ((System.Drawing.Image)(resources.GetObject("addDormerButton.Image")));
            this.addDormerButton.ImageSize = new System.Drawing.Size(20, 20);
            this.addDormerButton.Location = new System.Drawing.Point(1115, 3);
            this.addDormerButton.Name = "addDormerButton";
            this.addDormerButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.addDormerButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.addDormerButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.addDormerButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("addDormerButton.OnHoverImage")));
            this.addDormerButton.OnPressedColor = System.Drawing.Color.Black;
            this.addDormerButton.Radius = 9;
            this.addDormerButton.Size = new System.Drawing.Size(192, 36);
            this.addDormerButton.TabIndex = 8;
            this.addDormerButton.Text = "Add New Dormer";
            this.addDormerButton.Click += new System.EventHandler(this.addDormerButton_Click);
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.BaseColor = System.Drawing.Color.White;
            this.selectAllCheckBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.selectAllCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.selectAllCheckBox.FillColor = System.Drawing.Color.White;
            this.selectAllCheckBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectAllCheckBox.Location = new System.Drawing.Point(55, 630);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(114, 26);
            this.selectAllCheckBox.TabIndex = 10;
            this.selectAllCheckBox.Text = "Select All";
            this.selectAllCheckBox.CheckedChanged += new System.EventHandler(this.selectAllCheckBox_CheckedChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(51, 3);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(318, 23);
            this.gunaLabel3.TabIndex = 11;
            this.gunaLabel3.Text = "A.Y. 2023 - 2024 | 2nd Semester";
            // 
            // deleteButton
            // 
            this.deleteButton.AnimationHoverSpeed = 0.07F;
            this.deleteButton.AnimationSpeed = 0.03F;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BaseColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderSize = 1;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteButton.Location = new System.Drawing.Point(1224, 43);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverBaseColor = System.Drawing.Color.Black;
            this.deleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.OnHoverImage")));
            this.deleteButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteButton.Radius = 9;
            this.deleteButton.Size = new System.Drawing.Size(39, 36);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Refresh";
            this.deleteButton.Click += new System.EventHandler(this.deleteButtoon_Click);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(1139, 634);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(62, 23);
            this.gunaLabel8.TabIndex = 141;
            this.gunaLabel8.Text = "Page";
            // 
            // moveNextPage
            // 
            this.moveNextPage.Image = ((System.Drawing.Image)(resources.GetObject("moveNextPage.Image")));
            this.moveNextPage.ImageSize = new System.Drawing.Size(25, 25);
            this.moveNextPage.Location = new System.Drawing.Point(1275, 628);
            this.moveNextPage.Name = "moveNextPage";
            this.moveNextPage.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("moveNextPage.OnHoverImage")));
            this.moveNextPage.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.moveNextPage.Size = new System.Drawing.Size(26, 34);
            this.moveNextPage.TabIndex = 140;
            this.moveNextPage.Click += new System.EventHandler(this.moveNextPage_Click);
            // 
            // movePrevPage
            // 
            this.movePrevPage.Image = ((System.Drawing.Image)(resources.GetObject("movePrevPage.Image")));
            this.movePrevPage.ImageSize = new System.Drawing.Size(25, 25);
            this.movePrevPage.Location = new System.Drawing.Point(1111, 632);
            this.movePrevPage.Name = "movePrevPage";
            this.movePrevPage.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("movePrevPage.OnHoverImage")));
            this.movePrevPage.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.movePrevPage.Size = new System.Drawing.Size(25, 25);
            this.movePrevPage.TabIndex = 139;
            this.movePrevPage.Click += new System.EventHandler(this.movePrevPage_Click);
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.Location = new System.Drawing.Point(1250, 636);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(32, 23);
            this.over.TabIndex = 138;
            this.over.Text = "60";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(1221, 635);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(29, 23);
            this.gunaLabel4.TabIndex = 137;
            this.gunaLabel4.Text = "of";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(1201, 636);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(21, 23);
            this.count.TabIndex = 136;
            this.count.Text = "3";
            // 
            // printButton
            // 
            this.printButton.AnimationHoverSpeed = 0.07F;
            this.printButton.AnimationSpeed = 0.03F;
            this.printButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.printButton.BorderColor = System.Drawing.Color.White;
            this.printButton.BorderSize = 2;
            this.printButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageSize = new System.Drawing.Size(20, 20);
            this.printButton.Location = new System.Drawing.Point(1016, 4);
            this.printButton.Name = "printButton";
            this.printButton.OnHoverBaseColor = System.Drawing.Color.DarkCyan;
            this.printButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.printButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.printButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("printButton.OnHoverImage")));
            this.printButton.OnPressedColor = System.Drawing.Color.Black;
            this.printButton.Radius = 9;
            this.printButton.Size = new System.Drawing.Size(84, 36);
            this.printButton.TabIndex = 142;
            this.printButton.Text = "Print";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // dormersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.moveNextPage);
            this.Controls.Add(this.movePrevPage);
            this.Controls.Add(this.over);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.count);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.selectAllCheckBox);
            this.Controls.Add(this.addDormerButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.userTypeCB);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.viewCountCB);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.dormerTableView);
            this.Name = "dormersTab";
            this.Size = new System.Drawing.Size(1380, 810);
            ((System.ComponentModel.ISupportInitialize)(this.dormerTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dormerTableView;
        private Guna.UI.WinForms.GunaButton refreshButton;
        private Guna.UI.WinForms.GunaComboBox viewCountCB;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox userTypeCB;
        private Guna.UI.WinForms.GunaLineTextBox searchBar;
        private Guna.UI.WinForms.GunaButton searchButton;
        private Guna.UI.WinForms.GunaButton addDormerButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private Guna.UI.WinForms.GunaCheckBox selectAllCheckBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton deleteButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaImageButton moveNextPage;
        private Guna.UI.WinForms.GunaImageButton movePrevPage;
        private Guna.UI.WinForms.GunaLabel over;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel count;
        private Guna.UI.WinForms.GunaButton printButton;
    }
}
