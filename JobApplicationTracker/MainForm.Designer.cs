namespace JobApplicationTracker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Dashboard
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlStatTotal;
        private System.Windows.Forms.Panel pnlStatMonth;
        private System.Windows.Forms.Panel pnlStatInterviews;
        private System.Windows.Forms.Panel pnlStatOffers;
        private System.Windows.Forms.Panel pnlStatAwaiting;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblThisMonthTitle;
        private System.Windows.Forms.Label lblThisMonthVal;
        private System.Windows.Forms.Label lblInterviewsTitle;
        private System.Windows.Forms.Label lblInterviewsVal;
        private System.Windows.Forms.Label lblOffersTitle;
        private System.Windows.Forms.Label lblOffersVal;
        private System.Windows.Forms.Label lblAwaitingTitle;
        private System.Windows.Forms.Label lblAwaitingVal;

        // Filter bar
        private System.Windows.Forms.Panel   pnlFilter;
        private System.Windows.Forms.Panel   sepFilter;
        private System.Windows.Forms.Label   lblSearch;
        private System.Windows.Forms.Label   lblStatusFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbStatusFilter;

        // Button bar
        private System.Windows.Forms.Panel  pnlButtons;
        private System.Windows.Forms.Panel  sepButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExportCsv;

        // Grid
        private System.Windows.Forms.DataGridView dgvApplications;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlStatTotal = new System.Windows.Forms.Panel();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.pnlStatMonth = new System.Windows.Forms.Panel();
            this.lblThisMonthVal = new System.Windows.Forms.Label();
            this.lblThisMonthTitle = new System.Windows.Forms.Label();
            this.pnlStatInterviews = new System.Windows.Forms.Panel();
            this.lblInterviewsVal = new System.Windows.Forms.Label();
            this.lblInterviewsTitle = new System.Windows.Forms.Label();
            this.pnlStatOffers = new System.Windows.Forms.Panel();
            this.lblOffersVal = new System.Windows.Forms.Label();
            this.lblOffersTitle = new System.Windows.Forms.Label();
            this.pnlStatAwaiting = new System.Windows.Forms.Panel();
            this.lblAwaitingVal = new System.Windows.Forms.Label();
            this.lblAwaitingTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.sepFilter = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.sepButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.pnlDashboard.SuspendLayout();
            this.pnlStatTotal.SuspendLayout();
            this.pnlStatMonth.SuspendLayout();
            this.pnlStatInterviews.SuspendLayout();
            this.pnlStatOffers.SuspendLayout();
            this.pnlStatAwaiting.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlDashboard.Controls.Add(this.pnlStatTotal);
            this.pnlDashboard.Controls.Add(this.pnlStatMonth);
            this.pnlDashboard.Controls.Add(this.pnlStatInterviews);
            this.pnlDashboard.Controls.Add(this.pnlStatOffers);
            this.pnlDashboard.Controls.Add(this.pnlStatAwaiting);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlDashboard.Size = new System.Drawing.Size(1102, 90);
            this.pnlDashboard.TabIndex = 4;
            // 
            // pnlStatTotal
            // 
            this.pnlStatTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.pnlStatTotal.Controls.Add(this.lblTotalVal);
            this.pnlStatTotal.Controls.Add(this.lblTotalTitle);
            this.pnlStatTotal.Location = new System.Drawing.Point(12, 8);
            this.pnlStatTotal.Name = "pnlStatTotal";
            this.pnlStatTotal.Size = new System.Drawing.Size(170, 68);
            this.pnlStatTotal.TabIndex = 0;
            // 
            // lblTotalVal
            // 
            this.lblTotalVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalVal.ForeColor = System.Drawing.Color.White;
            this.lblTotalVal.Location = new System.Drawing.Point(6, 8);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(160, 30);
            this.lblTotalVal.TabIndex = 0;
            this.lblTotalVal.Text = "0";
            this.lblTotalVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblTotalTitle.Location = new System.Drawing.Point(6, 42);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(160, 18);
            this.lblTotalTitle.TabIndex = 1;
            this.lblTotalTitle.Text = "Total Applications";
            this.lblTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatMonth
            // 
            this.pnlStatMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.pnlStatMonth.Controls.Add(this.lblThisMonthVal);
            this.pnlStatMonth.Controls.Add(this.lblThisMonthTitle);
            this.pnlStatMonth.Location = new System.Drawing.Point(192, 8);
            this.pnlStatMonth.Name = "pnlStatMonth";
            this.pnlStatMonth.Size = new System.Drawing.Size(170, 68);
            this.pnlStatMonth.TabIndex = 1;
            // 
            // lblThisMonthVal
            // 
            this.lblThisMonthVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblThisMonthVal.ForeColor = System.Drawing.Color.White;
            this.lblThisMonthVal.Location = new System.Drawing.Point(6, 8);
            this.lblThisMonthVal.Name = "lblThisMonthVal";
            this.lblThisMonthVal.Size = new System.Drawing.Size(160, 30);
            this.lblThisMonthVal.TabIndex = 0;
            this.lblThisMonthVal.Text = "0";
            this.lblThisMonthVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThisMonthTitle
            // 
            this.lblThisMonthTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblThisMonthTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblThisMonthTitle.Location = new System.Drawing.Point(6, 42);
            this.lblThisMonthTitle.Name = "lblThisMonthTitle";
            this.lblThisMonthTitle.Size = new System.Drawing.Size(160, 18);
            this.lblThisMonthTitle.TabIndex = 1;
            this.lblThisMonthTitle.Text = "This Month";
            this.lblThisMonthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatInterviews
            // 
            this.pnlStatInterviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.pnlStatInterviews.Controls.Add(this.lblInterviewsVal);
            this.pnlStatInterviews.Controls.Add(this.lblInterviewsTitle);
            this.pnlStatInterviews.Location = new System.Drawing.Point(372, 8);
            this.pnlStatInterviews.Name = "pnlStatInterviews";
            this.pnlStatInterviews.Size = new System.Drawing.Size(170, 68);
            this.pnlStatInterviews.TabIndex = 2;
            // 
            // lblInterviewsVal
            // 
            this.lblInterviewsVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblInterviewsVal.ForeColor = System.Drawing.Color.White;
            this.lblInterviewsVal.Location = new System.Drawing.Point(6, 8);
            this.lblInterviewsVal.Name = "lblInterviewsVal";
            this.lblInterviewsVal.Size = new System.Drawing.Size(160, 30);
            this.lblInterviewsVal.TabIndex = 0;
            this.lblInterviewsVal.Text = "0";
            this.lblInterviewsVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInterviewsTitle
            // 
            this.lblInterviewsTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblInterviewsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblInterviewsTitle.Location = new System.Drawing.Point(6, 42);
            this.lblInterviewsTitle.Name = "lblInterviewsTitle";
            this.lblInterviewsTitle.Size = new System.Drawing.Size(160, 18);
            this.lblInterviewsTitle.TabIndex = 1;
            this.lblInterviewsTitle.Text = "Interviews";
            this.lblInterviewsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatOffers
            // 
            this.pnlStatOffers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.pnlStatOffers.Controls.Add(this.lblOffersVal);
            this.pnlStatOffers.Controls.Add(this.lblOffersTitle);
            this.pnlStatOffers.Location = new System.Drawing.Point(552, 8);
            this.pnlStatOffers.Name = "pnlStatOffers";
            this.pnlStatOffers.Size = new System.Drawing.Size(170, 68);
            this.pnlStatOffers.TabIndex = 3;
            // 
            // lblOffersVal
            // 
            this.lblOffersVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblOffersVal.ForeColor = System.Drawing.Color.White;
            this.lblOffersVal.Location = new System.Drawing.Point(6, 8);
            this.lblOffersVal.Name = "lblOffersVal";
            this.lblOffersVal.Size = new System.Drawing.Size(160, 30);
            this.lblOffersVal.TabIndex = 0;
            this.lblOffersVal.Text = "0";
            this.lblOffersVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOffersTitle
            // 
            this.lblOffersTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblOffersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblOffersTitle.Location = new System.Drawing.Point(6, 42);
            this.lblOffersTitle.Name = "lblOffersTitle";
            this.lblOffersTitle.Size = new System.Drawing.Size(160, 18);
            this.lblOffersTitle.TabIndex = 1;
            this.lblOffersTitle.Text = "Offers";
            this.lblOffersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatAwaiting
            // 
            this.pnlStatAwaiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlStatAwaiting.Controls.Add(this.lblAwaitingVal);
            this.pnlStatAwaiting.Controls.Add(this.lblAwaitingTitle);
            this.pnlStatAwaiting.Location = new System.Drawing.Point(732, 8);
            this.pnlStatAwaiting.Name = "pnlStatAwaiting";
            this.pnlStatAwaiting.Size = new System.Drawing.Size(170, 68);
            this.pnlStatAwaiting.TabIndex = 4;
            // 
            // lblAwaitingVal
            // 
            this.lblAwaitingVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAwaitingVal.ForeColor = System.Drawing.Color.White;
            this.lblAwaitingVal.Location = new System.Drawing.Point(6, 8);
            this.lblAwaitingVal.Name = "lblAwaitingVal";
            this.lblAwaitingVal.Size = new System.Drawing.Size(160, 30);
            this.lblAwaitingVal.TabIndex = 0;
            this.lblAwaitingVal.Text = "0";
            this.lblAwaitingVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAwaitingTitle
            // 
            this.lblAwaitingTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAwaitingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblAwaitingTitle.Location = new System.Drawing.Point(6, 42);
            this.lblAwaitingTitle.Name = "lblAwaitingTitle";
            this.lblAwaitingTitle.Size = new System.Drawing.Size(160, 18);
            this.lblAwaitingTitle.TabIndex = 1;
            this.lblAwaitingTitle.Text = "Awaiting Response";
            this.lblAwaitingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.lblSearch);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.lblStatusFilter);
            this.pnlFilter.Controls.Add(this.cmbStatusFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 90);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pnlFilter.Size = new System.Drawing.Size(1102, 52);
            this.pnlFilter.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.Location = new System.Drawing.Point(14, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(76, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(272, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatusFilter.Location = new System.Drawing.Point(370, 18);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(52, 20);
            this.lblStatusFilter.TabIndex = 2;
            this.lblStatusFilter.Text = "Status:";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatusFilter.Items.AddRange(new object[] {
            "All Statuses",
            "Saved / Draft",
            "Applied",
            "Under Review",
            "Phone Screen Scheduled",
            "Phone Screen Completed",
            "Interview Scheduled",
            "Interview Completed",
            "Technical Assessment",
            "Final Round",
            "Offer Received",
            "Offer Accepted",
            "Offer Declined",
            "Rejected",
            "Withdrawn",
            "No Response"});
            this.cmbStatusFilter.Location = new System.Drawing.Point(428, 14);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(210, 28);
            this.cmbStatusFilter.TabIndex = 3;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // sepFilter
            // 
            this.sepFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.sepFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.sepFilter.Location = new System.Drawing.Point(0, 142);
            this.sepFilter.Name = "sepFilter";
            this.sepFilter.Size = new System.Drawing.Size(1102, 1);
            this.sepFilter.TabIndex = 2;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.White;
            this.pnlButtons.Controls.Add(this.sepButtons);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnExportCsv);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 621);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlButtons.Size = new System.Drawing.Size(1102, 52);
            this.pnlButtons.TabIndex = 1;
            // 
            // sepButtons
            // 
            this.sepButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.sepButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.sepButtons.Location = new System.Drawing.Point(12, 8);
            this.sepButtons.Name = "sepButtons";
            this.sepButtons.Size = new System.Drawing.Size(1078, 1);
            this.sepButtons.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(14, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+ Add Application";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(182, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(278, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnExportCsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCsv.FlatAppearance.BorderSize = 0;
            this.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCsv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportCsv.ForeColor = System.Drawing.Color.White;
            this.btnExportCsv.Location = new System.Drawing.Point(374, 10);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(110, 32);
            this.btnExportCsv.TabIndex = 4;
            this.btnExportCsv.Text = "Export CSV";
            this.btnExportCsv.UseVisualStyleBackColor = false;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dgvApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvApplications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplications.ColumnHeadersHeight = 36;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApplications.EnableHeadersVisualStyles = false;
            this.dgvApplications.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvApplications.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
            this.dgvApplications.Location = new System.Drawing.Point(0, 150);
            this.dgvApplications.MultiSelect = false;
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.RowHeadersWidth = 51;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(1102, 478);
            this.dgvApplications.TabIndex = 0;
            this.dgvApplications.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplications_CellDoubleClick);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1102, 673);
            this.Controls.Add(this.dgvApplications);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.sepFilter);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlDashboard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Application Tracker";
            this.pnlDashboard.ResumeLayout(false);
            this.pnlStatTotal.ResumeLayout(false);
            this.pnlStatMonth.ResumeLayout(false);
            this.pnlStatInterviews.ResumeLayout(false);
            this.pnlStatOffers.ResumeLayout(false);
            this.pnlStatAwaiting.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.ResumeLayout(false);

        }
    }

    internal static class AppConstants
    {
        public static readonly string[] Statuses =
        {
            "Saved / Draft", "Applied", "Under Review",
            "Phone Screen Scheduled", "Phone Screen Completed",
            "Interview Scheduled", "Interview Completed",
            "Technical Assessment", "Final Round",
            "Offer Received", "Offer Accepted", "Offer Declined",
            "Rejected", "Withdrawn", "No Response"
        };

        public static readonly string[] JobTypes =
        {
            "Full-Time", "Part-Time", "Contract", "Freelance", "Internship", "Temporary"
        };

        public static readonly string[] WorkModes =
        {
            "Remote", "On-Site", "Hybrid"
        };

        public static readonly string[] Sources =
        {
            "LinkedIn", "Indeed", "Company Website", "Referral",
            "Job Fair", "Recruiter", "Dice", "ZipRecruiter", "Other"
        };
    }
}
