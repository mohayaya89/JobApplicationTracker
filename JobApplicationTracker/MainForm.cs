using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JobApplicationTracker.Data;
using JobApplicationTracker.Models;

namespace JobApplicationTracker
{
    public partial class MainForm : Form
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private List<JobApplication> _currentApps = new List<JobApplication>();

        // Status color map
        private static readonly Dictionary<string, Color> StatusColors = new Dictionary<string, Color>
        {
            { "Offer Received",             Color.FromArgb(198, 239, 206) },
            { "Offer Accepted",             Color.FromArgb(169, 231, 181) },
            { "Interview Scheduled",        Color.FromArgb(255, 242, 171) },
            { "Interview Completed",        Color.FromArgb(255, 235, 156) },
            { "Phone Screen Scheduled",     Color.FromArgb(255, 242, 171) },
            { "Phone Screen Completed",     Color.FromArgb(255, 235, 156) },
            { "Final Round",                Color.FromArgb(255, 230, 140) },
            { "Technical Assessment",       Color.FromArgb(255, 242, 171) },
            { "Under Review",               Color.FromArgb(189, 215, 238) },
            { "Applied",                    Color.FromArgb(221, 235, 247) },
            { "Rejected",                   Color.FromArgb(255, 199, 206) },
            { "Offer Declined",             Color.FromArgb(255, 199, 206) },
            { "Withdrawn",                  Color.FromArgb(217, 217, 217) },
            { "No Response",                Color.FromArgb(217, 217, 217) },
            { "Saved / Draft",              Color.FromArgb(242, 242, 242) },
        };

        public MainForm()
        {
            InitializeComponent();
            SetupGrid();
            SetupContextMenu();
            LoadApplications();
        }

        // ── Grid setup ─────────────────────────────────────────────────────────

        private void SetupGrid()
        {
            dgvApplications.AutoGenerateColumns = false;
            dgvApplications.Columns.Clear();

            AddColumn("JobTitle",         "Job Title",       200);
            AddColumn("CompanyName",      "Company",         150);
            AddColumn("Status",           "Status",          130);
            AddColumn("DateApplied",      "Date Applied",    100, "MM/dd/yyyy");
            AddColumn("JobType",          "Type",             90);
            AddColumn("WorkMode",         "Mode",             80);
            AddColumn("NextFollowUpDate", "Next Follow-Up",  110, "MM/dd/yyyy");
            AddColumn("ContactName",      "Contact",         120);

            dgvApplications.RowTemplate.Height = 28;
        }

        private void AddColumn(string dataMember, string header, int width, string format = null)
        {
            var col = new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataMember,
                HeaderText       = header,
                Width            = width,
                SortMode         = DataGridViewColumnSortMode.Automatic,
            };
            if (format != null) col.DefaultCellStyle.Format = format;
            dgvApplications.Columns.Add(col);
        }

        // ── Context menu ───────────────────────────────────────────────────────

        private void SetupContextMenu()
        {
            var menu = new ContextMenuStrip();
            menu.Items.Add("Edit",              null, (s, e) => EditSelected());
            menu.Items.Add("Delete",            null, (s, e) => DeleteSelected());
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add("Copy Job URL",      null, (s, e) => CopyJobUrl());
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add("Mark as Rejected",  null, (s, e) => SetStatus("Rejected"));
            menu.Items.Add("Mark as No Response", null, (s, e) => SetStatus("No Response"));
            dgvApplications.ContextMenuStrip = menu;
        }

        // ── Data loading ───────────────────────────────────────────────────────

        private void LoadApplications()
        {
            string kw     = txtSearch.Text.Trim();
            string status = cmbStatusFilter.SelectedItem?.ToString();

            _currentApps = _db.GetAll(kw, status);

            dgvApplications.DataSource = null;
            dgvApplications.DataSource = _currentApps;

            ColorRows();
            UpdateDashboard();
        }

        private void ColorRows()
        {
            foreach (DataGridViewRow row in dgvApplications.Rows)
            {
                if (row.DataBoundItem is JobApplication app &&
                    StatusColors.TryGetValue(app.Status ?? "", out Color c))
                {
                    row.DefaultCellStyle.BackColor = c;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void UpdateDashboard()
        {
            var s = _db.GetStats();
            lblTotalVal.Text       = s["Total"].ToString();
            lblThisMonthVal.Text   = s["ThisMonth"].ToString();
            lblInterviewsVal.Text  = s["Interviews"].ToString();
            lblOffersVal.Text      = s["Offers"].ToString();
            lblAwaitingVal.Text    = s["Awaiting"].ToString();
        }

        // ── Event handlers ─────────────────────────────────────────────────────

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadApplications();

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e) => LoadApplications();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new ApplicationForm(null, _db))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    LoadApplications();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) => EditSelected();

        private void btnDelete_Click(object sender, EventArgs e) => DeleteSelected();

        private void dgvApplications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) EditSelected();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog
            {
                Filter   = "CSV Files (*.csv)|*.csv",
                FileName = $"JobApplications_{DateTime.Now:yyyyMMdd}.csv",
                Title    = "Export to CSV"
            })
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                ExportToCsv(dlg.FileName);
            }
        }

        // ── Actions ────────────────────────────────────────────────────────────

        private void EditSelected()
        {
            var app = GetSelectedApp();
            if (app == null) return;
            using (var form = new ApplicationForm(app, _db))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    LoadApplications();
            }
        }

        private void DeleteSelected()
        {
            var app = GetSelectedApp();
            if (app == null) return;
            var result = MessageBox.Show(
                $"Are you sure you want to delete the application for\n\"{app.JobTitle}\" at {app.CompanyName}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;
            _db.Delete(app.Id);
            LoadApplications();
        }

        private void CopyJobUrl()
        {
            var app = GetSelectedApp();
            if (app == null) return;
            if (string.IsNullOrWhiteSpace(app.ApplicationUrl))
            {
                MessageBox.Show("No URL stored for this application.", "Copy URL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Clipboard.SetText(app.ApplicationUrl);
            MessageBox.Show("URL copied to clipboard.", "Copy URL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetStatus(string status)
        {
            var app = GetSelectedApp();
            if (app == null) return;
            app.Status = status;
            _db.Update(app);
            LoadApplications();
        }

        private JobApplication GetSelectedApp()
        {
            if (dgvApplications.CurrentRow?.DataBoundItem is JobApplication app)
                return app;
            MessageBox.Show("Please select a record first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        private void ExportToCsv(string filePath)
        {
            var sb = new StringBuilder();
            var headers = new[]
            {
                "Id","Job Title","Job Number","Job Type","Department","Salary Range",
                "Company Name","Company Address","Company Phone","Company Website","Work Mode",
                "Application URL","Application Source","Date Applied","Resume Version","Cover Letter Sent",
                "Contact Name","Contact Title","Contact Email","Contact Phone",
                "Status","Last Follow-Up","Next Follow-Up","Interview Date/Time",
                "Notes","Created Date","Updated Date"
            };
            sb.AppendLine(string.Join(",", headers));

            foreach (var a in _currentApps)
            {
                var fields = new[]
                {
                    a.Id.ToString(),
                    CsvEsc(a.JobTitle), CsvEsc(a.JobNumber), CsvEsc(a.JobType),
                    CsvEsc(a.Department), CsvEsc(a.SalaryRange),
                    CsvEsc(a.CompanyName), CsvEsc(a.CompanyAddress),
                    CsvEsc(a.CompanyPhone), CsvEsc(a.CompanyWebsite), CsvEsc(a.WorkMode),
                    CsvEsc(a.ApplicationUrl), CsvEsc(a.ApplicationSource),
                    a.DateApplied.ToString("MM/dd/yyyy"),
                    CsvEsc(a.ResumeVersion),
                    a.CoverLetterSent ? "Yes" : "No",
                    CsvEsc(a.ContactName), CsvEsc(a.ContactTitle),
                    CsvEsc(a.ContactEmail), CsvEsc(a.ContactPhone),
                    CsvEsc(a.Status),
                    a.LastFollowUpDate?.ToString("MM/dd/yyyy") ?? "",
                    a.NextFollowUpDate?.ToString("MM/dd/yyyy") ?? "",
                    a.InterviewDateTime?.ToString("MM/dd/yyyy HH:mm") ?? "",
                    CsvEsc(a.Notes),
                    a.CreatedDate.ToString("MM/dd/yyyy"),
                    a.UpdatedDate.ToString("MM/dd/yyyy")
                };
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
            MessageBox.Show($"Exported {_currentApps.Count} records to:\n{filePath}",
                "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string CsvEsc(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            s = s.Replace("\"", "\"\"");
            return s.Contains(',') || s.Contains('"') || s.Contains('\n') ? $"\"{s}\"" : s;
        }
    }
}
