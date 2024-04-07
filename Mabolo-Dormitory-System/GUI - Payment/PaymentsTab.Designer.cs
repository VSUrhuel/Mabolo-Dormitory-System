namespace Mabolo_Dormitory_System.GUI___Payment
{
    partial class PaymentsTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsTab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.searchBut = new Guna.UI.WinForms.GunaButton();
            this.searchBar = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.itemCB = new Guna.UI.WinForms.GunaComboBox();
            this.refreshBut = new Guna.UI.WinForms.GunaButton();
            this.dormerTableView = new Guna.UI.WinForms.GunaDataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.statusCB = new Guna.UI.WinForms.GunaComboBox();
            this.count = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.over = new Guna.UI.WinForms.GunaLabel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.addDormerButton = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dormerTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(60, 7);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(318, 23);
            this.gunaLabel3.TabIndex = 22;
            this.gunaLabel3.Text = "A.Y. 2023 - 2024 | 2nd Semester";
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
            this.searchBut.Location = new System.Drawing.Point(226, 46);
            this.searchBut.Name = "searchBut";
            this.searchBut.OnHoverBaseColor = System.Drawing.Color.SeaGreen;
            this.searchBut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchBut.OnHoverForeColor = System.Drawing.Color.White;
            this.searchBut.OnHoverImage = null;
            this.searchBut.OnPressedColor = System.Drawing.Color.Black;
            this.searchBut.Size = new System.Drawing.Size(41, 36);
            this.searchBut.TabIndex = 20;
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.White;
            this.searchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.FocusedLineColor = System.Drawing.Color.ForestGreen;
            this.searchBar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.searchBar.LineSize = 2;
            this.searchBar.Location = new System.Drawing.Point(56, 45);
            this.searchBar.Margin = new System.Windows.Forms.Padding(0);
            this.searchBar.Name = "searchBar";
            this.searchBar.PasswordChar = '\0';
            this.searchBar.Size = new System.Drawing.Size(211, 35);
            this.searchBar.TabIndex = 13;
            this.searchBar.Text = "Search...";
            this.searchBar.TextOffsetX = 10;
            this.searchBar.Click += new System.EventHandler(this.searchBar_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1166, 56);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(64, 23);
            this.gunaLabel1.TabIndex = 17;
            this.gunaLabel1.Text = "View:";
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
            this.itemCB.Location = new System.Drawing.Point(1220, 50);
            this.itemCB.Name = "itemCB";
            this.itemCB.OnHoverItemBaseColor = System.Drawing.Color.ForestGreen;
            this.itemCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.itemCB.Radius = 9;
            this.itemCB.Size = new System.Drawing.Size(52, 33);
            this.itemCB.TabIndex = 16;
            this.itemCB.SelectedIndexChanged += new System.EventHandler(this.itemCB_SelectedIndexChanged);
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
            this.refreshBut.Location = new System.Drawing.Point(1277, 46);
            this.refreshBut.Name = "refreshBut";
            this.refreshBut.OnHoverBaseColor = System.Drawing.Color.Black;
            this.refreshBut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refreshBut.OnHoverForeColor = System.Drawing.Color.White;
            this.refreshBut.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("refreshBut.OnHoverImage")));
            this.refreshBut.OnPressedColor = System.Drawing.Color.Black;
            this.refreshBut.Radius = 9;
            this.refreshBut.Size = new System.Drawing.Size(39, 36);
            this.refreshBut.TabIndex = 15;
            this.refreshBut.Text = "Refresh";
            this.refreshBut.Click += new System.EventHandler(this.refreshBut_Click);
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
            this.UserId,
            this.FirstName,
            this.LastName,
            this.RemainingBalance,
            this.Status,
            this.Action});
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
            this.dormerTableView.Location = new System.Drawing.Point(53, 87);
            this.dormerTableView.Name = "dormerTableView";
            this.dormerTableView.RowHeadersVisible = false;
            this.dormerTableView.RowHeadersWidth = 51;
            this.dormerTableView.RowTemplate.Height = 24;
            this.dormerTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dormerTableView.Size = new System.Drawing.Size(1263, 518);
            this.dormerTableView.TabIndex = 14;
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
            // UserId
            // 
            this.UserId.HeaderText = "User ID";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // RemainingBalance
            // 
            this.RemainingBalance.HeaderText = "Remaining Balance";
            this.RemainingBalance.MinimumWidth = 6;
            this.RemainingBalance.Name = "RemainingBalance";
            this.RemainingBalance.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Items.AddRange(new object[] {
            "Add Payment",
            "View Payments"});
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(925, 56);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(73, 23);
            this.gunaLabel4.TabIndex = 25;
            this.gunaLabel4.Text = "Status:";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // statusCB
            // 
            this.statusCB.BackColor = System.Drawing.Color.Transparent;
            this.statusCB.BaseColor = System.Drawing.Color.White;
            this.statusCB.BorderColor = System.Drawing.Color.Silver;
            this.statusCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCB.ForeColor = System.Drawing.Color.Black;
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Items.AddRange(new object[] {
            "Paid",
            "Pending",
            "All"});
            this.statusCB.Location = new System.Drawing.Point(993, 50);
            this.statusCB.Name = "statusCB";
            this.statusCB.OnHoverItemBaseColor = System.Drawing.Color.ForestGreen;
            this.statusCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.statusCB.Radius = 9;
            this.statusCB.Size = new System.Drawing.Size(167, 33);
            this.statusCB.TabIndex = 24;
            this.statusCB.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(1202, 614);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(21, 23);
            this.count.TabIndex = 129;
            this.count.Text = "3";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(1221, 613);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(29, 23);
            this.gunaLabel2.TabIndex = 130;
            this.gunaLabel2.Text = "of";
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.Location = new System.Drawing.Point(1250, 614);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(32, 23);
            this.over.TabIndex = 131;
            this.over.Text = "60";
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaImageButton1.Location = new System.Drawing.Point(1113, 610);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.OnHoverImage")));
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(25, 25);
            this.gunaImageButton1.TabIndex = 133;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.Image")));
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaImageButton2.Location = new System.Drawing.Point(1274, 610);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton2.OnHoverImage")));
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(25, 25);
            this.gunaImageButton2.TabIndex = 134;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(1142, 613);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(62, 23);
            this.gunaLabel8.TabIndex = 135;
            this.gunaLabel8.Text = "Page";
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
            this.addDormerButton.Location = new System.Drawing.Point(1114, 4);
            this.addDormerButton.Name = "addDormerButton";
            this.addDormerButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.addDormerButton.OnHoverBorderColor = System.Drawing.Color.White;
            this.addDormerButton.OnHoverForeColor = System.Drawing.Color.Black;
            this.addDormerButton.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("addDormerButton.OnHoverImage")));
            this.addDormerButton.OnPressedColor = System.Drawing.Color.Black;
            this.addDormerButton.Radius = 9;
            this.addDormerButton.Size = new System.Drawing.Size(202, 36);
            this.addDormerButton.TabIndex = 136;
            this.addDormerButton.Text = "Payments Summary";
            this.addDormerButton.Click += new System.EventHandler(this.addDormerButton_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.White;
            this.gunaButton1.BorderSize = 2;
            this.gunaButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(915, 4);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton1.OnHoverImage")));
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 9;
            this.gunaButton1.Size = new System.Drawing.Size(192, 36);
            this.gunaButton1.TabIndex = 137;
            this.gunaButton1.Text = "Regular Payables";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // PaymentsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.addDormerButton);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaImageButton2);
            this.Controls.Add(this.gunaImageButton1);
            this.Controls.Add(this.over);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.count);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.statusCB);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.searchBut);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.itemCB);
            this.Controls.Add(this.refreshBut);
            this.Controls.Add(this.dormerTableView);
            this.Name = "PaymentsTab";
            this.Size = new System.Drawing.Size(1380, 810);
            ((System.ComponentModel.ISupportInitialize)(this.dormerTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton searchBut;
        private Guna.UI.WinForms.GunaLineTextBox searchBar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox itemCB;
        private Guna.UI.WinForms.GunaButton refreshBut;
        private Guna.UI.WinForms.GunaDataGridView dormerTableView;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox statusCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewComboBoxColumn Action;
        private Guna.UI.WinForms.GunaLabel count;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel over;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaButton addDormerButton;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}
