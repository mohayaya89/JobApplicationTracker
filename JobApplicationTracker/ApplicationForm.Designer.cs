namespace JobApplicationTracker
{
    partial class ApplicationForm
    {
        private System.ComponentModel.IContainer components = null;

        // Panels
        private System.Windows.Forms.Panel   pnlBtns;
        private System.Windows.Forms.Panel   sepBtn;
        private System.Windows.Forms.Panel   pnlMain;

        // Group boxes
        private System.Windows.Forms.GroupBox grpJob;
        private System.Windows.Forms.GroupBox grpCompany;
        private System.Windows.Forms.GroupBox grpApp;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.GroupBox grpNotes;

        // Labels – Job Details
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblJobNumber;
        private System.Windows.Forms.Label lblJobType;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblSalaryRange;

        // Labels – Company
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblCompanyPhone;
        private System.Windows.Forms.Label lblCompanyWebsite;
        private System.Windows.Forms.Label lblWorkMode;

        // Labels – Application
        private System.Windows.Forms.Label lblAppUrl;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDateApplied;
        private System.Windows.Forms.Label lblResumeVersion;
        private System.Windows.Forms.Label lblCoverLetter;

        // Labels – Contact
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblContactEmail;
        private System.Windows.Forms.Label lblContactPhone;

        // Labels – Status
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLastFollowUp;
        private System.Windows.Forms.Label lblNextFollowUp;
        private System.Windows.Forms.Label lblInterview;

        // Job Details inputs
        private System.Windows.Forms.TextBox  txtJobTitle;
        private System.Windows.Forms.TextBox  txtJobNumber;
        private System.Windows.Forms.ComboBox cmbJobType;
        private System.Windows.Forms.TextBox  txtDepartment;
        private System.Windows.Forms.TextBox  txtSalaryRange;

        // Company inputs
        private System.Windows.Forms.TextBox  txtCompanyName;
        private System.Windows.Forms.TextBox  txtCompanyAddress;
        private System.Windows.Forms.TextBox  txtCompanyPhone;
        private System.Windows.Forms.TextBox  txtCompanyWebsite;
        private System.Windows.Forms.ComboBox cmbWorkMode;

        // Application inputs
        private System.Windows.Forms.TextBox        txtAppUrl;
        private System.Windows.Forms.Button         btnOpenUrl;
        private System.Windows.Forms.ComboBox       cmbSource;
        private System.Windows.Forms.DateTimePicker dtpDateApplied;
        private System.Windows.Forms.TextBox        txtResumeVersion;
        private System.Windows.Forms.CheckBox       chkCoverLetter;

        // Contact inputs
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.TextBox txtContactPhone;

        // Status inputs
        private System.Windows.Forms.ComboBox       cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpLastFollowUp;
        private System.Windows.Forms.DateTimePicker dtpNextFollowUp;
        private System.Windows.Forms.DateTimePicker dtpInterview;

        // Notes
        private System.Windows.Forms.TextBox txtNotes;

        // Bottom buttons
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.sepBtn = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grpJob = new System.Windows.Forms.GroupBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblJobNumber = new System.Windows.Forms.Label();
            this.txtJobNumber = new System.Windows.Forms.TextBox();
            this.lblJobType = new System.Windows.Forms.Label();
            this.cmbJobType = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblSalaryRange = new System.Windows.Forms.Label();
            this.txtSalaryRange = new System.Windows.Forms.TextBox();
            this.grpCompany = new System.Windows.Forms.GroupBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.lblCompanyPhone = new System.Windows.Forms.Label();
            this.txtCompanyPhone = new System.Windows.Forms.TextBox();
            this.lblCompanyWebsite = new System.Windows.Forms.Label();
            this.txtCompanyWebsite = new System.Windows.Forms.TextBox();
            this.lblWorkMode = new System.Windows.Forms.Label();
            this.cmbWorkMode = new System.Windows.Forms.ComboBox();
            this.grpApp = new System.Windows.Forms.GroupBox();
            this.lblAppUrl = new System.Windows.Forms.Label();
            this.txtAppUrl = new System.Windows.Forms.TextBox();
            this.btnOpenUrl = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.lblDateApplied = new System.Windows.Forms.Label();
            this.dtpDateApplied = new System.Windows.Forms.DateTimePicker();
            this.lblResumeVersion = new System.Windows.Forms.Label();
            this.txtResumeVersion = new System.Windows.Forms.TextBox();
            this.lblCoverLetter = new System.Windows.Forms.Label();
            this.chkCoverLetter = new System.Windows.Forms.CheckBox();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblLastFollowUp = new System.Windows.Forms.Label();
            this.dtpLastFollowUp = new System.Windows.Forms.DateTimePicker();
            this.lblNextFollowUp = new System.Windows.Forms.Label();
            this.dtpNextFollowUp = new System.Windows.Forms.DateTimePicker();
            this.lblInterview = new System.Windows.Forms.Label();
            this.dtpInterview = new System.Windows.Forms.DateTimePicker();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pnlBtns.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpJob.SuspendLayout();
            this.grpCompany.SuspendLayout();
            this.grpApp.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtns
            // 
            this.pnlBtns.BackColor = System.Drawing.Color.White;
            this.pnlBtns.Controls.Add(this.btnDelete);
            this.pnlBtns.Controls.Add(this.btnCancel);
            this.pnlBtns.Controls.Add(this.btnSave);
            this.pnlBtns.Controls.Add(this.sepBtn);
            this.pnlBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtns.Location = new System.Drawing.Point(0, 757);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(762, 56);
            this.pnlBtns.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(234, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 34);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(134, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 34);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(14, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sepBtn
            // 
            this.sepBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.sepBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sepBtn.Location = new System.Drawing.Point(0, 0);
            this.sepBtn.Name = "sepBtn";
            this.sepBtn.Size = new System.Drawing.Size(762, 1);
            this.sepBtn.TabIndex = 3;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.AutoScrollMinSize = new System.Drawing.Size(736, 1136);
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlMain.Controls.Add(this.grpJob);
            this.pnlMain.Controls.Add(this.grpCompany);
            this.pnlMain.Controls.Add(this.grpApp);
            this.pnlMain.Controls.Add(this.grpContact);
            this.pnlMain.Controls.Add(this.grpStatus);
            this.pnlMain.Controls.Add(this.grpNotes);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(762, 757);
            this.pnlMain.TabIndex = 0;
            // 
            // grpJob
            // 
            this.grpJob.BackColor = System.Drawing.Color.White;
            this.grpJob.Controls.Add(this.lblJobTitle);
            this.grpJob.Controls.Add(this.txtJobTitle);
            this.grpJob.Controls.Add(this.lblJobNumber);
            this.grpJob.Controls.Add(this.txtJobNumber);
            this.grpJob.Controls.Add(this.lblJobType);
            this.grpJob.Controls.Add(this.cmbJobType);
            this.grpJob.Controls.Add(this.lblDepartment);
            this.grpJob.Controls.Add(this.txtDepartment);
            this.grpJob.Controls.Add(this.lblSalaryRange);
            this.grpJob.Controls.Add(this.txtSalaryRange);
            this.grpJob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.grpJob.Location = new System.Drawing.Point(10, 10);
            this.grpJob.Name = "grpJob";
            this.grpJob.Size = new System.Drawing.Size(716, 198);
            this.grpJob.TabIndex = 0;
            this.grpJob.TabStop = false;
            this.grpJob.Text = "Job Details";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblJobTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblJobTitle.Location = new System.Drawing.Point(10, 27);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(138, 20);
            this.lblJobTitle.TabIndex = 0;
            this.lblJobTitle.Text = "Job Title *";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJobTitle.Location = new System.Drawing.Point(154, 24);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(538, 27);
            this.txtJobTitle.TabIndex = 1;
            // 
            // lblJobNumber
            // 
            this.lblJobNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblJobNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblJobNumber.Location = new System.Drawing.Point(10, 59);
            this.lblJobNumber.Name = "lblJobNumber";
            this.lblJobNumber.Size = new System.Drawing.Size(138, 20);
            this.lblJobNumber.TabIndex = 2;
            this.lblJobNumber.Text = "Job Ref #";
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJobNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJobNumber.Location = new System.Drawing.Point(154, 56);
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.Size = new System.Drawing.Size(538, 27);
            this.txtJobNumber.TabIndex = 3;
            // 
            // lblJobType
            // 
            this.lblJobType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblJobType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblJobType.Location = new System.Drawing.Point(10, 91);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new System.Drawing.Size(138, 20);
            this.lblJobType.TabIndex = 4;
            this.lblJobType.Text = "Job Type";
            // 
            // cmbJobType
            // 
            this.cmbJobType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbJobType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbJobType.Location = new System.Drawing.Point(154, 88);
            this.cmbJobType.Name = "cmbJobType";
            this.cmbJobType.Size = new System.Drawing.Size(212, 28);
            this.cmbJobType.TabIndex = 5;
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblDepartment.Location = new System.Drawing.Point(10, 123);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(138, 20);
            this.lblDepartment.TabIndex = 6;
            this.lblDepartment.Text = "Department";
            // 
            // txtDepartment
            // 
            this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDepartment.Location = new System.Drawing.Point(154, 120);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(538, 27);
            this.txtDepartment.TabIndex = 7;
            // 
            // lblSalaryRange
            // 
            this.lblSalaryRange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSalaryRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblSalaryRange.Location = new System.Drawing.Point(10, 155);
            this.lblSalaryRange.Name = "lblSalaryRange";
            this.lblSalaryRange.Size = new System.Drawing.Size(138, 20);
            this.lblSalaryRange.TabIndex = 8;
            this.lblSalaryRange.Text = "Salary Range";
            // 
            // txtSalaryRange
            // 
            this.txtSalaryRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalaryRange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalaryRange.Location = new System.Drawing.Point(154, 152);
            this.txtSalaryRange.Name = "txtSalaryRange";
            this.txtSalaryRange.Size = new System.Drawing.Size(538, 27);
            this.txtSalaryRange.TabIndex = 9;
            // 
            // grpCompany
            // 
            this.grpCompany.BackColor = System.Drawing.Color.White;
            this.grpCompany.Controls.Add(this.lblCompanyName);
            this.grpCompany.Controls.Add(this.txtCompanyName);
            this.grpCompany.Controls.Add(this.lblCompanyAddress);
            this.grpCompany.Controls.Add(this.txtCompanyAddress);
            this.grpCompany.Controls.Add(this.lblCompanyPhone);
            this.grpCompany.Controls.Add(this.txtCompanyPhone);
            this.grpCompany.Controls.Add(this.lblCompanyWebsite);
            this.grpCompany.Controls.Add(this.txtCompanyWebsite);
            this.grpCompany.Controls.Add(this.lblWorkMode);
            this.grpCompany.Controls.Add(this.cmbWorkMode);
            this.grpCompany.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.grpCompany.Location = new System.Drawing.Point(10, 218);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(716, 198);
            this.grpCompany.TabIndex = 1;
            this.grpCompany.TabStop = false;
            this.grpCompany.Text = "Company Details";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblCompanyName.Location = new System.Drawing.Point(10, 27);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(138, 20);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name *";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCompanyName.Location = new System.Drawing.Point(154, 24);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(538, 27);
            this.txtCompanyName.TabIndex = 1;
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompanyAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblCompanyAddress.Location = new System.Drawing.Point(10, 59);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(138, 20);
            this.lblCompanyAddress.TabIndex = 2;
            this.lblCompanyAddress.Text = "Address / Location";
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCompanyAddress.Location = new System.Drawing.Point(154, 56);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(538, 27);
            this.txtCompanyAddress.TabIndex = 3;
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompanyPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblCompanyPhone.Location = new System.Drawing.Point(10, 91);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(138, 20);
            this.lblCompanyPhone.TabIndex = 4;
            this.lblCompanyPhone.Text = "Phone";
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCompanyPhone.Location = new System.Drawing.Point(154, 88);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Size = new System.Drawing.Size(538, 27);
            this.txtCompanyPhone.TabIndex = 5;
            // 
            // lblCompanyWebsite
            // 
            this.lblCompanyWebsite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCompanyWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblCompanyWebsite.Location = new System.Drawing.Point(10, 123);
            this.lblCompanyWebsite.Name = "lblCompanyWebsite";
            this.lblCompanyWebsite.Size = new System.Drawing.Size(138, 20);
            this.lblCompanyWebsite.TabIndex = 6;
            this.lblCompanyWebsite.Text = "Website";
            // 
            // txtCompanyWebsite
            // 
            this.txtCompanyWebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyWebsite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCompanyWebsite.Location = new System.Drawing.Point(154, 120);
            this.txtCompanyWebsite.Name = "txtCompanyWebsite";
            this.txtCompanyWebsite.Size = new System.Drawing.Size(538, 27);
            this.txtCompanyWebsite.TabIndex = 7;
            // 
            // lblWorkMode
            // 
            this.lblWorkMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWorkMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblWorkMode.Location = new System.Drawing.Point(10, 155);
            this.lblWorkMode.Name = "lblWorkMode";
            this.lblWorkMode.Size = new System.Drawing.Size(138, 20);
            this.lblWorkMode.TabIndex = 8;
            this.lblWorkMode.Text = "Work Mode";
            // 
            // cmbWorkMode
            // 
            this.cmbWorkMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbWorkMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbWorkMode.Location = new System.Drawing.Point(154, 152);
            this.cmbWorkMode.Name = "cmbWorkMode";
            this.cmbWorkMode.Size = new System.Drawing.Size(212, 28);
            this.cmbWorkMode.TabIndex = 9;
            // 
            // grpApp
            // 
            this.grpApp.BackColor = System.Drawing.Color.White;
            this.grpApp.Controls.Add(this.lblAppUrl);
            this.grpApp.Controls.Add(this.txtAppUrl);
            this.grpApp.Controls.Add(this.btnOpenUrl);
            this.grpApp.Controls.Add(this.lblSource);
            this.grpApp.Controls.Add(this.cmbSource);
            this.grpApp.Controls.Add(this.lblDateApplied);
            this.grpApp.Controls.Add(this.dtpDateApplied);
            this.grpApp.Controls.Add(this.lblResumeVersion);
            this.grpApp.Controls.Add(this.txtResumeVersion);
            this.grpApp.Controls.Add(this.lblCoverLetter);
            this.grpApp.Controls.Add(this.chkCoverLetter);
            this.grpApp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.grpApp.Location = new System.Drawing.Point(10, 426);
            this.grpApp.Name = "grpApp";
            this.grpApp.Size = new System.Drawing.Size(716, 198);
            this.grpApp.TabIndex = 2;
            this.grpApp.TabStop = false;
            this.grpApp.Text = "Application Details";
            // 
            // lblAppUrl
            // 
            this.lblAppUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblAppUrl.Location = new System.Drawing.Point(10, 27);
            this.lblAppUrl.Name = "lblAppUrl";
            this.lblAppUrl.Size = new System.Drawing.Size(138, 20);
            this.lblAppUrl.TabIndex = 0;
            this.lblAppUrl.Text = "Application URL";
            // 
            // txtAppUrl
            // 
            this.txtAppUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAppUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAppUrl.Location = new System.Drawing.Point(154, 24);
            this.txtAppUrl.Name = "txtAppUrl";
            this.txtAppUrl.Size = new System.Drawing.Size(458, 27);
            this.txtAppUrl.TabIndex = 1;
            // 
            // btnOpenUrl
            // 
            this.btnOpenUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnOpenUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenUrl.FlatAppearance.BorderSize = 0;
            this.btnOpenUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenUrl.ForeColor = System.Drawing.Color.White;
            this.btnOpenUrl.Location = new System.Drawing.Point(618, 23);
            this.btnOpenUrl.Name = "btnOpenUrl";
            this.btnOpenUrl.Size = new System.Drawing.Size(68, 26);
            this.btnOpenUrl.TabIndex = 2;
            this.btnOpenUrl.Text = "Open";
            this.btnOpenUrl.UseVisualStyleBackColor = false;
            this.btnOpenUrl.Click += new System.EventHandler(this.btnOpenUrl_Click);
            // 
            // lblSource
            // 
            this.lblSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblSource.Location = new System.Drawing.Point(10, 59);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(138, 20);
            this.lblSource.TabIndex = 3;
            this.lblSource.Text = "Source";
            // 
            // cmbSource
            // 
            this.cmbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSource.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSource.Location = new System.Drawing.Point(154, 56);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(212, 28);
            this.cmbSource.TabIndex = 4;
            // 
            // lblDateApplied
            // 
            this.lblDateApplied.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDateApplied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblDateApplied.Location = new System.Drawing.Point(10, 91);
            this.lblDateApplied.Name = "lblDateApplied";
            this.lblDateApplied.Size = new System.Drawing.Size(138, 20);
            this.lblDateApplied.TabIndex = 5;
            this.lblDateApplied.Text = "Date Applied";
            // 
            // dtpDateApplied
            // 
            this.dtpDateApplied.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateApplied.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateApplied.Location = new System.Drawing.Point(154, 88);
            this.dtpDateApplied.Name = "dtpDateApplied";
            this.dtpDateApplied.Size = new System.Drawing.Size(212, 27);
            this.dtpDateApplied.TabIndex = 6;
            // 
            // lblResumeVersion
            // 
            this.lblResumeVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblResumeVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblResumeVersion.Location = new System.Drawing.Point(10, 123);
            this.lblResumeVersion.Name = "lblResumeVersion";
            this.lblResumeVersion.Size = new System.Drawing.Size(138, 20);
            this.lblResumeVersion.TabIndex = 7;
            this.lblResumeVersion.Text = "Resume Version";
            // 
            // txtResumeVersion
            // 
            this.txtResumeVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResumeVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtResumeVersion.Location = new System.Drawing.Point(154, 120);
            this.txtResumeVersion.Name = "txtResumeVersion";
            this.txtResumeVersion.Size = new System.Drawing.Size(538, 27);
            this.txtResumeVersion.TabIndex = 8;
            // 
            // lblCoverLetter
            // 
            this.lblCoverLetter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCoverLetter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblCoverLetter.Location = new System.Drawing.Point(10, 155);
            this.lblCoverLetter.Name = "lblCoverLetter";
            this.lblCoverLetter.Size = new System.Drawing.Size(138, 20);
            this.lblCoverLetter.TabIndex = 9;
            this.lblCoverLetter.Text = "Cover Letter";
            // 
            // chkCoverLetter
            // 
            this.chkCoverLetter.AutoSize = true;
            this.chkCoverLetter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkCoverLetter.Location = new System.Drawing.Point(154, 154);
            this.chkCoverLetter.Name = "chkCoverLetter";
            this.chkCoverLetter.Size = new System.Drawing.Size(60, 24);
            this.chkCoverLetter.TabIndex = 10;
            this.chkCoverLetter.Text = "Sent";
            // 
            // grpContact
            // 
            this.grpContact.BackColor = System.Drawing.Color.White;
            this.grpContact.Controls.Add(this.lblContactName);
            this.grpContact.Controls.Add(this.txtContactName);
            this.grpContact.Controls.Add(this.lblContactTitle);
            this.grpContact.Controls.Add(this.txtContactTitle);
            this.grpContact.Controls.Add(this.lblContactEmail);
            this.grpContact.Controls.Add(this.txtContactEmail);
            this.grpContact.Controls.Add(this.lblContactPhone);
            this.grpContact.Controls.Add(this.txtContactPhone);
            this.grpContact.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.grpContact.Location = new System.Drawing.Point(10, 634);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(716, 166);
            this.grpContact.TabIndex = 3;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact / Recruiter  (all optional)";
            // 
            // lblContactName
            // 
            this.lblContactName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContactName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblContactName.Location = new System.Drawing.Point(10, 27);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(138, 20);
            this.lblContactName.TabIndex = 0;
            this.lblContactName.Text = "Contact Name";
            // 
            // txtContactName
            // 
            this.txtContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContactName.Location = new System.Drawing.Point(154, 24);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(538, 27);
            this.txtContactName.TabIndex = 1;
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContactTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblContactTitle.Location = new System.Drawing.Point(10, 59);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(138, 20);
            this.lblContactTitle.TabIndex = 2;
            this.lblContactTitle.Text = "Title / Role";
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContactTitle.Location = new System.Drawing.Point(154, 56);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(538, 27);
            this.txtContactTitle.TabIndex = 3;
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContactEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblContactEmail.Location = new System.Drawing.Point(10, 91);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(138, 20);
            this.lblContactEmail.TabIndex = 4;
            this.lblContactEmail.Text = "Email";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContactEmail.Location = new System.Drawing.Point(154, 88);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(538, 27);
            this.txtContactEmail.TabIndex = 5;
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContactPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblContactPhone.Location = new System.Drawing.Point(10, 123);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(138, 20);
            this.lblContactPhone.TabIndex = 6;
            this.lblContactPhone.Text = "Phone";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContactPhone.Location = new System.Drawing.Point(154, 120);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(538, 27);
            this.txtContactPhone.TabIndex = 7;
            // 
            // grpStatus
            // 
            this.grpStatus.BackColor = System.Drawing.Color.White;
            this.grpStatus.Controls.Add(this.lblStatus);
            this.grpStatus.Controls.Add(this.cmbStatus);
            this.grpStatus.Controls.Add(this.lblLastFollowUp);
            this.grpStatus.Controls.Add(this.dtpLastFollowUp);
            this.grpStatus.Controls.Add(this.lblNextFollowUp);
            this.grpStatus.Controls.Add(this.dtpNextFollowUp);
            this.grpStatus.Controls.Add(this.lblInterview);
            this.grpStatus.Controls.Add(this.dtpInterview);
            this.grpStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.grpStatus.Location = new System.Drawing.Point(10, 810);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(716, 166);
            this.grpStatus.TabIndex = 4;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status Tracking";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblStatus.Location = new System.Drawing.Point(10, 27);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(138, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatus.Location = new System.Drawing.Point(154, 24);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(212, 28);
            this.cmbStatus.TabIndex = 1;
            // 
            // lblLastFollowUp
            // 
            this.lblLastFollowUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastFollowUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblLastFollowUp.Location = new System.Drawing.Point(10, 59);
            this.lblLastFollowUp.Name = "lblLastFollowUp";
            this.lblLastFollowUp.Size = new System.Drawing.Size(138, 20);
            this.lblLastFollowUp.TabIndex = 2;
            this.lblLastFollowUp.Text = "Last Follow-Up";
            // 
            // dtpLastFollowUp
            // 
            this.dtpLastFollowUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpLastFollowUp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLastFollowUp.Location = new System.Drawing.Point(154, 56);
            this.dtpLastFollowUp.Name = "dtpLastFollowUp";
            this.dtpLastFollowUp.ShowCheckBox = true;
            this.dtpLastFollowUp.Size = new System.Drawing.Size(212, 27);
            this.dtpLastFollowUp.TabIndex = 3;
            // 
            // lblNextFollowUp
            // 
            this.lblNextFollowUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNextFollowUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblNextFollowUp.Location = new System.Drawing.Point(10, 91);
            this.lblNextFollowUp.Name = "lblNextFollowUp";
            this.lblNextFollowUp.Size = new System.Drawing.Size(138, 20);
            this.lblNextFollowUp.TabIndex = 4;
            this.lblNextFollowUp.Text = "Next Follow-Up";
            // 
            // dtpNextFollowUp
            // 
            this.dtpNextFollowUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNextFollowUp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNextFollowUp.Location = new System.Drawing.Point(154, 88);
            this.dtpNextFollowUp.Name = "dtpNextFollowUp";
            this.dtpNextFollowUp.ShowCheckBox = true;
            this.dtpNextFollowUp.Size = new System.Drawing.Size(212, 27);
            this.dtpNextFollowUp.TabIndex = 5;
            // 
            // lblInterview
            // 
            this.lblInterview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInterview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblInterview.Location = new System.Drawing.Point(10, 123);
            this.lblInterview.Name = "lblInterview";
            this.lblInterview.Size = new System.Drawing.Size(138, 20);
            this.lblInterview.TabIndex = 6;
            this.lblInterview.Text = "Interview Date";
            // 
            // dtpInterview
            // 
            this.dtpInterview.CustomFormat = "MM/dd/yyyy  h:mm tt";
            this.dtpInterview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpInterview.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInterview.Location = new System.Drawing.Point(154, 120);
            this.dtpInterview.Name = "dtpInterview";
            this.dtpInterview.ShowCheckBox = true;
            this.dtpInterview.Size = new System.Drawing.Size(212, 27);
            this.dtpInterview.TabIndex = 7;
            // 
            // grpNotes
            // 
            this.grpNotes.BackColor = System.Drawing.Color.White;
            this.grpNotes.Controls.Add(this.txtNotes);
            this.grpNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.grpNotes.Location = new System.Drawing.Point(10, 986);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Size = new System.Drawing.Size(716, 130);
            this.grpNotes.TabIndex = 5;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "Notes / Comments";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(10, 24);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(692, 100);
            this.txtNotes.TabIndex = 0;
            // 
            // ApplicationForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(762, 813);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBtns);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(760, 600);
            this.Name = "ApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application";
            this.pnlBtns.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.grpJob.ResumeLayout(false);
            this.grpJob.PerformLayout();
            this.grpCompany.ResumeLayout(false);
            this.grpCompany.PerformLayout();
            this.grpApp.ResumeLayout(false);
            this.grpApp.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
