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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.delBut = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.searchBut = new Guna.UI.WinForms.GunaButton();
            this.searchBar = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.regularPayablesCB = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.itemCB = new Guna.UI.WinForms.GunaComboBox();
            this.refreshBut = new Guna.UI.WinForms.GunaButton();
            this.dormerTableView = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.eventPayabalesCB = new Guna.UI.WinForms.GunaComboBox();
            this.selectAllCB = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.receivedPayment = new Guna.UI.WinForms.GunaLabel();
            this.pendingCollectibles = new Guna.UI.WinForms.GunaLabel();
            this.updateViewButton = new Guna.UI.WinForms.GunaButton();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dormerTableView)).BeginInit();
            this.SuspendLayout();
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
            this.delBut.Location = new System.Drawing.Point(1233, 47);
            this.delBut.Name = "delBut";
            this.delBut.OnHoverBaseColor = System.Drawing.Color.Black;
            this.delBut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.delBut.OnHoverForeColor = System.Drawing.Color.White;
            this.delBut.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("delBut.OnHoverImage")));
            this.delBut.OnPressedColor = System.Drawing.Color.Black;
            this.delBut.Radius = 9;
            this.delBut.Size = new System.Drawing.Size(39, 36);
            this.delBut.TabIndex = 23;
            this.delBut.Text = "Refresh";
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
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(297, 53);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(187, 23);
            this.gunaLabel2.TabIndex = 19;
            this.gunaLabel2.Text = "Regular Payables:";
            // 
            // regularPayablesCB
            // 
            this.regularPayablesCB.BackColor = System.Drawing.Color.Transparent;
            this.regularPayablesCB.BaseColor = System.Drawing.Color.White;
            this.regularPayablesCB.BorderColor = System.Drawing.Color.Silver;
            this.regularPayablesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.regularPayablesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regularPayablesCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularPayablesCB.ForeColor = System.Drawing.Color.Black;
            this.regularPayablesCB.FormattingEnabled = true;
            this.regularPayablesCB.Location = new System.Drawing.Point(473, 48);
            this.regularPayablesCB.Name = "regularPayablesCB";
            this.regularPayablesCB.OnHoverItemBaseColor = System.Drawing.Color.ForestGreen;
            this.regularPayablesCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.regularPayablesCB.Radius = 9;
            this.regularPayablesCB.Size = new System.Drawing.Size(239, 33);
            this.regularPayablesCB.TabIndex = 18;
            this.regularPayablesCB.SelectedIndexChanged += new System.EventHandler(this.regularPayablesCB_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(1116, 56);
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
            this.itemCB.Location = new System.Drawing.Point(1170, 50);
            this.itemCB.Name = "itemCB";
            this.itemCB.OnHoverItemBaseColor = System.Drawing.Color.ForestGreen;
            this.itemCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.itemCB.Radius = 9;
            this.itemCB.Size = new System.Drawing.Size(52, 33);
            this.itemCB.TabIndex = 16;
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
            this.UserId,
            this.FirstName,
            this.LastName,
            this.RemainingBalance,
            this.Status});
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
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(718, 54);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(168, 23);
            this.gunaLabel4.TabIndex = 25;
            this.gunaLabel4.Text = "Event Payables:";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // eventPayabalesCB
            // 
            this.eventPayabalesCB.BackColor = System.Drawing.Color.Transparent;
            this.eventPayabalesCB.BaseColor = System.Drawing.Color.White;
            this.eventPayabalesCB.BorderColor = System.Drawing.Color.Silver;
            this.eventPayabalesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.eventPayabalesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventPayabalesCB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventPayabalesCB.ForeColor = System.Drawing.Color.Black;
            this.eventPayabalesCB.FormattingEnabled = true;
            this.eventPayabalesCB.Location = new System.Drawing.Point(854, 49);
            this.eventPayabalesCB.Name = "eventPayabalesCB";
            this.eventPayabalesCB.OnHoverItemBaseColor = System.Drawing.Color.ForestGreen;
            this.eventPayabalesCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.eventPayabalesCB.Radius = 9;
            this.eventPayabalesCB.Size = new System.Drawing.Size(239, 33);
            this.eventPayabalesCB.TabIndex = 24;
            this.eventPayabalesCB.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // selectAllCB
            // 
            this.selectAllCB.BaseColor = System.Drawing.Color.White;
            this.selectAllCB.CheckedOffColor = System.Drawing.Color.Gray;
            this.selectAllCB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.selectAllCB.FillColor = System.Drawing.Color.White;
            this.selectAllCB.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectAllCB.Location = new System.Drawing.Point(53, 611);
            this.selectAllCB.Name = "selectAllCB";
            this.selectAllCB.Size = new System.Drawing.Size(114, 26);
            this.selectAllCB.TabIndex = 26;
            this.selectAllCB.Text = "Select All";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(814, 11);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(192, 23);
            this.gunaLabel5.TabIndex = 27;
            this.gunaLabel5.Text = "Received Amount:";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(1060, 13);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(217, 23);
            this.gunaLabel6.TabIndex = 126;
            this.gunaLabel6.Text = "Pending Collectibles:";
            // 
            // receivedPayment
            // 
            this.receivedPayment.AutoSize = true;
            this.receivedPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedPayment.Location = new System.Drawing.Point(1012, 11);
            this.receivedPayment.Name = "receivedPayment";
            this.receivedPayment.Size = new System.Drawing.Size(21, 23);
            this.receivedPayment.TabIndex = 127;
            this.receivedPayment.Text = "1";
            // 
            // pendingCollectibles
            // 
            this.pendingCollectibles.AutoSize = true;
            this.pendingCollectibles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingCollectibles.Location = new System.Drawing.Point(1283, 13);
            this.pendingCollectibles.Name = "pendingCollectibles";
            this.pendingCollectibles.Size = new System.Drawing.Size(21, 23);
            this.pendingCollectibles.TabIndex = 128;
            this.pendingCollectibles.Text = "1";
            // 
            // updateViewButton
            // 
            this.updateViewButton.AnimationHoverSpeed = 0.07F;
            this.updateViewButton.AnimationSpeed = 0.03F;
            this.updateViewButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(62)))));
            this.updateViewButton.BorderColor = System.Drawing.Color.Black;
            this.updateViewButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateViewButton.ForeColor = System.Drawing.Color.White;
            this.updateViewButton.Image = null;
            this.updateViewButton.ImageSize = new System.Drawing.Size(20, 20);
            this.updateViewButton.Location = new System.Drawing.Point(1156, 611);
            this.updateViewButton.Name = "updateViewButton";
            this.updateViewButton.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.updateViewButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateViewButton.OnHoverForeColor = System.Drawing.Color.White;
            this.updateViewButton.OnHoverImage = null;
            this.updateViewButton.OnPressedColor = System.Drawing.Color.Black;
            this.updateViewButton.Radius = 10;
            this.updateViewButton.Size = new System.Drawing.Size(160, 42);
            this.updateViewButton.TabIndex = 129;
            this.updateViewButton.Text = "Update";
            this.updateViewButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateViewButton.Click += new System.EventHandler(this.updateViewButton_Click);
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
            // PaymentsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateViewButton);
            this.Controls.Add(this.pendingCollectibles);
            this.Controls.Add(this.receivedPayment);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.selectAllCB);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.eventPayabalesCB);
            this.Controls.Add(this.delBut);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.searchBut);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.regularPayablesCB);
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

        private Guna.UI.WinForms.GunaButton delBut;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaButton searchBut;
        private Guna.UI.WinForms.GunaLineTextBox searchBar;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox regularPayablesCB;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox itemCB;
        private Guna.UI.WinForms.GunaButton refreshBut;
        private Guna.UI.WinForms.GunaDataGridView dormerTableView;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox eventPayabalesCB;
        private Guna.UI.WinForms.GunaCheckBox selectAllCB;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel receivedPayment;
        private Guna.UI.WinForms.GunaLabel pendingCollectibles;
        private Guna.UI.WinForms.GunaButton updateViewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
