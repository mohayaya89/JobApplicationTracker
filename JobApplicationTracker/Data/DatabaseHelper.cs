using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using JobApplicationTracker.Models;

namespace JobApplicationTracker.Data
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper()
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JobApplications.db");
            _connectionString = $"Data Source={dbPath};Version=3;";
            CreateTableIfNotExists();
        }

        private void CreateTableIfNotExists()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                const string sql = @"
                    CREATE TABLE IF NOT EXISTS JobApplications (
                        Id                INTEGER PRIMARY KEY AUTOINCREMENT,
                        JobTitle          TEXT NOT NULL,
                        JobNumber         TEXT,
                        JobType           TEXT,
                        Department        TEXT,
                        SalaryRange       TEXT,
                        CompanyName       TEXT NOT NULL,
                        CompanyAddress    TEXT,
                        CompanyPhone      TEXT,
                        CompanyWebsite    TEXT,
                        WorkMode          TEXT,
                        ApplicationUrl    TEXT,
                        ApplicationSource TEXT,
                        DateApplied       TEXT,
                        ResumeVersion     TEXT,
                        CoverLetterSent   INTEGER DEFAULT 0,
                        ContactName       TEXT,
                        ContactTitle      TEXT,
                        ContactEmail      TEXT,
                        ContactPhone      TEXT,
                        Status            TEXT,
                        LastFollowUpDate  TEXT,
                        NextFollowUpDate  TEXT,
                        InterviewDateTime TEXT,
                        Notes             TEXT,
                        CreatedDate       TEXT,
                        UpdatedDate       TEXT
                    )";
                using (var cmd = new SQLiteCommand(sql, conn))
                    cmd.ExecuteNonQuery();
            }
        }

        public List<JobApplication> GetAll(string searchKeyword = null, string statusFilter = null)
        {
            var list = new List<JobApplication>();
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM JobApplications WHERE 1=1";
                if (!string.IsNullOrWhiteSpace(searchKeyword))
                    sql += " AND (JobTitle LIKE @kw OR CompanyName LIKE @kw OR Status LIKE @kw OR ContactName LIKE @kw)";
                if (!string.IsNullOrWhiteSpace(statusFilter) && statusFilter != "All Statuses")
                    sql += " AND Status = @status";
                sql += " ORDER BY DateApplied DESC, Id DESC";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    if (!string.IsNullOrWhiteSpace(searchKeyword))
                        cmd.Parameters.AddWithValue("@kw", $"%{searchKeyword}%");
                    if (!string.IsNullOrWhiteSpace(statusFilter) && statusFilter != "All Statuses")
                        cmd.Parameters.AddWithValue("@status", statusFilter);

                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                            list.Add(MapFromReader(reader));
                }
            }
            return list;
        }

        public JobApplication GetById(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("SELECT * FROM JobApplications WHERE Id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                        if (reader.Read()) return MapFromReader(reader);
                }
            }
            return null;
        }

        public void Insert(JobApplication app)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                const string sql = @"
                    INSERT INTO JobApplications
                        (JobTitle, JobNumber, JobType, Department, SalaryRange,
                         CompanyName, CompanyAddress, CompanyPhone, CompanyWebsite, WorkMode,
                         ApplicationUrl, ApplicationSource, DateApplied, ResumeVersion, CoverLetterSent,
                         ContactName, ContactTitle, ContactEmail, ContactPhone,
                         Status, LastFollowUpDate, NextFollowUpDate, InterviewDateTime,
                         Notes, CreatedDate, UpdatedDate)
                    VALUES
                        (@JobTitle, @JobNumber, @JobType, @Department, @SalaryRange,
                         @CompanyName, @CompanyAddress, @CompanyPhone, @CompanyWebsite, @WorkMode,
                         @ApplicationUrl, @ApplicationSource, @DateApplied, @ResumeVersion, @CoverLetterSent,
                         @ContactName, @ContactTitle, @ContactEmail, @ContactPhone,
                         @Status, @LastFollowUpDate, @NextFollowUpDate, @InterviewDateTime,
                         @Notes, @CreatedDate, @UpdatedDate)";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    AddParameters(cmd, app);
                    string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cmd.Parameters.AddWithValue("@CreatedDate", now);
                    cmd.Parameters.AddWithValue("@UpdatedDate", now);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(JobApplication app)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                const string sql = @"
                    UPDATE JobApplications SET
                        JobTitle=@JobTitle, JobNumber=@JobNumber, JobType=@JobType,
                        Department=@Department, SalaryRange=@SalaryRange,
                        CompanyName=@CompanyName, CompanyAddress=@CompanyAddress,
                        CompanyPhone=@CompanyPhone, CompanyWebsite=@CompanyWebsite, WorkMode=@WorkMode,
                        ApplicationUrl=@ApplicationUrl, ApplicationSource=@ApplicationSource,
                        DateApplied=@DateApplied, ResumeVersion=@ResumeVersion, CoverLetterSent=@CoverLetterSent,
                        ContactName=@ContactName, ContactTitle=@ContactTitle,
                        ContactEmail=@ContactEmail, ContactPhone=@ContactPhone,
                        Status=@Status, LastFollowUpDate=@LastFollowUpDate,
                        NextFollowUpDate=@NextFollowUpDate, InterviewDateTime=@InterviewDateTime,
                        Notes=@Notes, UpdatedDate=@UpdatedDate
                    WHERE Id=@Id";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    AddParameters(cmd, app);
                    cmd.Parameters.AddWithValue("@UpdatedDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Id", app.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand("DELETE FROM JobApplications WHERE Id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Dictionary<string, int> GetStats()
        {
            var stats = new Dictionary<string, int>();
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();

                using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM JobApplications", conn))
                    stats["Total"] = Convert.ToInt32(cmd.ExecuteScalar());

                string thisMonth = DateTime.Now.ToString("yyyy-MM");
                using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM JobApplications WHERE DateApplied LIKE @m", conn))
                {
                    cmd.Parameters.AddWithValue("@m", $"{thisMonth}%");
                    stats["ThisMonth"] = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (var cmd = new SQLiteCommand(
                    "SELECT COUNT(*) FROM JobApplications WHERE Status IN ('Interview Scheduled','Phone Screen Scheduled','Final Round')", conn))
                    stats["Interviews"] = Convert.ToInt32(cmd.ExecuteScalar());

                using (var cmd = new SQLiteCommand(
                    "SELECT COUNT(*) FROM JobApplications WHERE Status IN ('Offer Received','Offer Accepted')", conn))
                    stats["Offers"] = Convert.ToInt32(cmd.ExecuteScalar());

                string sevenDaysAgo = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd HH:mm:ss");
                using (var cmd = new SQLiteCommand(@"
                    SELECT COUNT(*) FROM JobApplications
                    WHERE UpdatedDate < @d
                    AND Status NOT IN ('Offer Accepted','Offer Declined','Rejected','Withdrawn','No Response')", conn))
                {
                    cmd.Parameters.AddWithValue("@d", sevenDaysAgo);
                    stats["Awaiting"] = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return stats;
        }

        private void AddParameters(SQLiteCommand cmd, JobApplication a)
        {
            cmd.Parameters.AddWithValue("@JobTitle", a.JobTitle ?? "");
            cmd.Parameters.AddWithValue("@JobNumber", a.JobNumber ?? "");
            cmd.Parameters.AddWithValue("@JobType", a.JobType ?? "");
            cmd.Parameters.AddWithValue("@Department", a.Department ?? "");
            cmd.Parameters.AddWithValue("@SalaryRange", a.SalaryRange ?? "");
            cmd.Parameters.AddWithValue("@CompanyName", a.CompanyName ?? "");
            cmd.Parameters.AddWithValue("@CompanyAddress", a.CompanyAddress ?? "");
            cmd.Parameters.AddWithValue("@CompanyPhone", a.CompanyPhone ?? "");
            cmd.Parameters.AddWithValue("@CompanyWebsite", a.CompanyWebsite ?? "");
            cmd.Parameters.AddWithValue("@WorkMode", a.WorkMode ?? "");
            cmd.Parameters.AddWithValue("@ApplicationUrl", a.ApplicationUrl ?? "");
            cmd.Parameters.AddWithValue("@ApplicationSource", a.ApplicationSource ?? "");
            cmd.Parameters.AddWithValue("@DateApplied", a.DateApplied.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@ResumeVersion", a.ResumeVersion ?? "");
            cmd.Parameters.AddWithValue("@CoverLetterSent", a.CoverLetterSent ? 1 : 0);
            cmd.Parameters.AddWithValue("@ContactName", a.ContactName ?? "");
            cmd.Parameters.AddWithValue("@ContactTitle", a.ContactTitle ?? "");
            cmd.Parameters.AddWithValue("@ContactEmail", a.ContactEmail ?? "");
            cmd.Parameters.AddWithValue("@ContactPhone", a.ContactPhone ?? "");
            cmd.Parameters.AddWithValue("@Status", a.Status ?? "");
            cmd.Parameters.AddWithValue("@LastFollowUpDate",
                a.LastFollowUpDate.HasValue ? (object)a.LastFollowUpDate.Value.ToString("yyyy-MM-dd") : DBNull.Value);
            cmd.Parameters.AddWithValue("@NextFollowUpDate",
                a.NextFollowUpDate.HasValue ? (object)a.NextFollowUpDate.Value.ToString("yyyy-MM-dd") : DBNull.Value);
            cmd.Parameters.AddWithValue("@InterviewDateTime",
                a.InterviewDateTime.HasValue ? (object)a.InterviewDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss") : DBNull.Value);
            cmd.Parameters.AddWithValue("@Notes", a.Notes ?? "");
        }

        private JobApplication MapFromReader(IDataReader r)
        {
            return new JobApplication
            {
                Id                = Convert.ToInt32(r["Id"]),
                JobTitle          = r["JobTitle"].ToString(),
                JobNumber         = r["JobNumber"].ToString(),
                JobType           = r["JobType"].ToString(),
                Department        = r["Department"].ToString(),
                SalaryRange       = r["SalaryRange"].ToString(),
                CompanyName       = r["CompanyName"].ToString(),
                CompanyAddress    = r["CompanyAddress"].ToString(),
                CompanyPhone      = r["CompanyPhone"].ToString(),
                CompanyWebsite    = r["CompanyWebsite"].ToString(),
                WorkMode          = r["WorkMode"].ToString(),
                ApplicationUrl    = r["ApplicationUrl"].ToString(),
                ApplicationSource = r["ApplicationSource"].ToString(),
                DateApplied       = ParseDate(r["DateApplied"].ToString()) ?? DateTime.Today,
                ResumeVersion     = r["ResumeVersion"].ToString(),
                CoverLetterSent   = Convert.ToInt32(r["CoverLetterSent"]) == 1,
                ContactName       = r["ContactName"].ToString(),
                ContactTitle      = r["ContactTitle"].ToString(),
                ContactEmail      = r["ContactEmail"].ToString(),
                ContactPhone      = r["ContactPhone"].ToString(),
                Status            = r["Status"].ToString(),
                LastFollowUpDate  = ParseDate(r["LastFollowUpDate"].ToString()),
                NextFollowUpDate  = ParseDate(r["NextFollowUpDate"].ToString()),
                InterviewDateTime = ParseDate(r["InterviewDateTime"].ToString()),
                Notes             = r["Notes"].ToString(),
                CreatedDate       = ParseDate(r["CreatedDate"].ToString()) ?? DateTime.Now,
                UpdatedDate       = ParseDate(r["UpdatedDate"].ToString()) ?? DateTime.Now,
            };
        }

        private DateTime? ParseDate(string s)
        {
            if (string.IsNullOrEmpty(s)) return null;
            return DateTime.TryParse(s, out var d) ? d : (DateTime?)null;
        }
    }
}
