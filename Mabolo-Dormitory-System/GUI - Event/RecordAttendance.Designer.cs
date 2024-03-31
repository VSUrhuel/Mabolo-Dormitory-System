namespace Mabolo_Dormitory_System.GUI___Event
{
    partial class RecordAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordAttendance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.updateViewButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.dormerTableView = new Guna.UI.WinForms.GunaDataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.eventTitle = new Guna.UI.WinForms.GunaLineTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormerTableView)).BeginInit();
            this.SuspendLayout();
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
            this.updateViewButton.Location = new System.Drawing.Point(611, 747);
            this.updateViewButton.Name = "updateViewButton";
            this.updateViewButton.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.updateViewButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateViewButton.OnHoverForeColor = System.Drawing.Color.White;
            this.updateViewButton.OnHoverImage = null;
            this.updateViewButton.OnPressedColor = System.Drawing.Color.Black;
            this.updateViewButton.Radius = 10;
            this.updateViewButton.Size = new System.Drawing.Size(160, 42);
            this.updateViewButton.TabIndex = 121;
            this.updateViewButton.Text = "Update";
            this.updateViewButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateViewButton.Click += new System.EventHandler(this.updateViewButton_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(298, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(195, 34);
            this.gunaLabel1.TabIndex = 120;
            this.gunaLabel1.Text = "ATTENDANCE";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(-145, -3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(1096, 10);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 119;
            this.gunaPictureBox1.TabStop = false;
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
            this.Attendance});
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
            this.dormerTableView.Location = new System.Drawing.Point(17, 99);
            this.dormerTableView.Name = "dormerTableView";
            this.dormerTableView.RowHeadersVisible = false;
            this.dormerTableView.RowHeadersWidth = 51;
            this.dormerTableView.RowTemplate.Height = 24;
            this.dormerTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dormerTableView.Size = new System.Drawing.Size(754, 628);
            this.dormerTableView.TabIndex = 122;
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
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            // 
            // Attendance
            // 
            this.Attendance.HeaderText = "Record";
            this.Attendance.MinimumWidth = 6;
            this.Attendance.Name = "Attendance";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(13, 65);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(138, 23);
            this.gunaLabel2.TabIndex = 123;
            this.gunaLabel2.Text = "Event Name:";
            // 
            // eventTitle
            // 
            this.eventTitle.BackColor = System.Drawing.Color.White;
            this.eventTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eventTitle.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.eventTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTitle.LineColor = System.Drawing.Color.Gainsboro;
            this.eventTitle.Location = new System.Drawing.Point(157, 60);
            this.eventTitle.Name = "eventTitle";
            this.eventTitle.PasswordChar = '\0';
            this.eventTitle.Size = new System.Drawing.Size(252, 33);
            this.eventTitle.TabIndex = 124;
            // 
            // RecordAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 801);
            this.Controls.Add(this.eventTitle);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.dormerTableView);
            this.Controls.Add(this.updateViewButton);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecordAttendance";
            this.Text = "RecordAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormerTableView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton updateViewButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaDataGridView dormerTableView;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attendance;
        private Guna.UI.WinForms.GunaLineTextBox eventTitle;
    }
}