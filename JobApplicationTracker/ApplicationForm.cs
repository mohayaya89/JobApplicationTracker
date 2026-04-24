using System;
using System.Diagnostics;
using System.Windows.Forms;
using JobApplicationTracker.Data;
using JobApplicationTracker.Models;

namespace JobApplicationTracker
{
    public partial class ApplicationForm : Form
    {
        private readonly DatabaseHelper _db;
        private readonly JobApplication _app;
        private readonly bool _isEdit;

        //public ApplicationForm() { InitializeComponent(); }

        public ApplicationForm(JobApplication app, DatabaseHelper db)
        {
            _db    = db;
            _isEdit = app != null;
            _app   = app ?? new JobApplication
            {
                DateApplied = DateTime.Today,
                Status      = "Applied",
                JobType     = "Full-Time",
                WorkMode    = "On-Site"
            };
            InitializeComponent();
            PopulateDropdowns();
            PopulateForm();
        }

        // ── Populate ────────────────────────────────────────────────────────

        private void PopulateDropdowns()
        {
            cmbJobType.Items.AddRange(AppConstants.JobTypes);
            cmbWorkMode.Items.AddRange(AppConstants.WorkModes);
            cmbSource.Items.AddRange(AppConstants.Sources);
            cmbStatus.Items.AddRange(AppConstants.Statuses);
        }

        private void PopulateForm()
        {
            // Job Details
            txtJobTitle.Text    = _app.JobTitle ?? "";
            txtJobNumber.Text   = _app.JobNumber ?? "";
            SetCombo(cmbJobType, _app.JobType, "Full-Time");
            txtDepartment.Text  = _app.Department ?? "";
            txtSalaryRange.Text = _app.SalaryRange ?? "";

            // Company
            txtCompanyName.Text    = _app.CompanyName ?? "";
            txtCompanyAddress.Text = _app.CompanyAddress ?? "";
            txtCompanyPhone.Text   = _app.CompanyPhone ?? "";
            txtCompanyWebsite.Text = _app.CompanyWebsite ?? "";
            SetCombo(cmbWorkMode, _app.WorkMode, "On-Site");

            // Application
            txtAppUrl.Text        = _app.ApplicationUrl ?? "";
            SetCombo(cmbSource, _app.ApplicationSource, "Company Website");
            dtpDateApplied.Value  = _app.DateApplied == default ? DateTime.Today : _app.DateApplied;
            txtResumeVersion.Text = _app.ResumeVersion ?? "";
            chkCoverLetter.Checked = _app.CoverLetterSent;

            // Contact
            txtContactName.Text  = _app.ContactName ?? "";
            txtContactTitle.Text = _app.ContactTitle ?? "";
            txtContactEmail.Text = _app.ContactEmail ?? "";
            txtContactPhone.Text = _app.ContactPhone ?? "";

            // Status
            SetCombo(cmbStatus, _app.Status, "Applied");
            SetOptionalDate(dtpLastFollowUp, _app.LastFollowUpDate);
            SetOptionalDate(dtpNextFollowUp, _app.NextFollowUpDate);
            SetOptionalDate(dtpInterview,    _app.InterviewDateTime);

            // Notes
            txtNotes.Text = _app.Notes ?? "";

            // Delete button visibility
            btnDelete.Visible = _isEdit;

            this.Text = _isEdit
                ? $"Edit — {_app.JobTitle} @ {_app.CompanyName}"
                : "Add New Application";
        }

        private void SetCombo(ComboBox cmb, string value, string fallback)
        {
            int idx = cmb.Items.IndexOf(value ?? "");
            cmb.SelectedIndex = idx >= 0 ? idx : cmb.Items.IndexOf(fallback);
            if (cmb.SelectedIndex < 0 && cmb.Items.Count > 0) cmb.SelectedIndex = 0;
        }

        private void SetOptionalDate(DateTimePicker dtp, DateTime? value)
        {
            dtp.ShowCheckBox = true;
            if (value.HasValue)
            {
                dtp.Checked = true;
                dtp.Value   = value.Value;
            }
            else
            {
                dtp.Checked = false;
                dtp.Value   = DateTime.Today;
            }
        }

        // ── Save ────────────────────────────────────────────────────────────

        private bool Validate_Fields()
        {
            if (string.IsNullOrWhiteSpace(txtJobTitle.Text))
            {
                MessageBox.Show("Job Title is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobTitle.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                MessageBox.Show("Company Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompanyName.Focus();
                return false;
            }
            return true;
        }

        private void SaveForm()
        {
            _app.JobTitle          = txtJobTitle.Text.Trim();
            _app.JobNumber         = txtJobNumber.Text.Trim();
            _app.JobType           = cmbJobType.SelectedItem?.ToString();
            _app.Department        = txtDepartment.Text.Trim();
            _app.SalaryRange       = txtSalaryRange.Text.Trim();

            _app.CompanyName       = txtCompanyName.Text.Trim();
            _app.CompanyAddress    = txtCompanyAddress.Text.Trim();
            _app.CompanyPhone      = txtCompanyPhone.Text.Trim();
            _app.CompanyWebsite    = txtCompanyWebsite.Text.Trim();
            _app.WorkMode          = cmbWorkMode.SelectedItem?.ToString();

            _app.ApplicationUrl    = txtAppUrl.Text.Trim();
            _app.ApplicationSource = cmbSource.SelectedItem?.ToString();
            _app.DateApplied       = dtpDateApplied.Value;
            _app.ResumeVersion     = txtResumeVersion.Text.Trim();
            _app.CoverLetterSent   = chkCoverLetter.Checked;

            _app.ContactName       = txtContactName.Text.Trim();
            _app.ContactTitle      = txtContactTitle.Text.Trim();
            _app.ContactEmail      = txtContactEmail.Text.Trim();
            _app.ContactPhone      = txtContactPhone.Text.Trim();

            _app.Status            = cmbStatus.SelectedItem?.ToString();
            _app.LastFollowUpDate  = dtpLastFollowUp.Checked ? dtpLastFollowUp.Value : (DateTime?)null;
            _app.NextFollowUpDate  = dtpNextFollowUp.Checked ? dtpNextFollowUp.Value : (DateTime?)null;
            _app.InterviewDateTime = dtpInterview.Checked    ? dtpInterview.Value    : (DateTime?)null;

            _app.Notes             = txtNotes.Text.Trim();

            if (_isEdit)
                _db.Update(_app);
            else
                _db.Insert(_app);
        }

        // ── Event handlers ──────────────────────────────────────────────────

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate_Fields()) return;
            try
            {
                SaveForm();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Delete \"{_app.JobTitle}\" at {_app.CompanyName}?\nThis cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;
            _db.Delete(_app.Id);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOpenUrl_Click(object sender, EventArgs e)
        {
            string url = txtAppUrl.Text.Trim();
            if (string.IsNullOrEmpty(url)) { MessageBox.Show("No URL entered.", "Open URL"); return; }
            if (!url.StartsWith("http", StringComparison.OrdinalIgnoreCase)) url = "https://" + url;
            try { Process.Start(url); }
            catch { MessageBox.Show("Could not open URL.", "Error"); }
        }
    }
}
