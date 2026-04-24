using System;

namespace JobApplicationTracker.Models
{
    public class JobApplication
    {
        public int Id { get; set; }

        // Job Details
        public string JobTitle { get; set; }
        public string JobNumber { get; set; }
        public string JobType { get; set; }
        public string Department { get; set; }
        public string SalaryRange { get; set; }

        // Company Details
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyWebsite { get; set; }
        public string WorkMode { get; set; }

        // Application Details
        public string ApplicationUrl { get; set; }
        public string ApplicationSource { get; set; }
        public DateTime DateApplied { get; set; }
        public string ResumeVersion { get; set; }
        public bool CoverLetterSent { get; set; }

        // Contact / Recruiter
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }

        // Status Tracking
        public string Status { get; set; }
        public DateTime? LastFollowUpDate { get; set; }
        public DateTime? NextFollowUpDate { get; set; }
        public DateTime? InterviewDateTime { get; set; }

        // Notes
        public string Notes { get; set; }

        // Metadata
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
