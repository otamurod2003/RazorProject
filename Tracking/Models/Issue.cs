namespace Tracking.Models
{
    public class Issue
    {

        public uint id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Priority Priorities { get; set; }

        public IssueType Issuetype { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }

        public enum Priority
        {
            Low,
            Medium,
            High
        }
        public enum IssueType
        {
            Faeture,
            Bug,
            Documentation
        }
    }
}
