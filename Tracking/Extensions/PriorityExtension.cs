using Tracking.Models;
using static Tracking.Models.Issue;

namespace Tracking.Extensions
{
    public static class PriorityExtension
    {
        static readonly Dictionary<Priority, string> _priorityCssClasses = new()
        {
            [Priority.High] = "badge bg-danger",
            [Priority.Medium] = "badge bg-warning text-dark",
            [Priority.Low] = "badge bg-success"
        };
        public static string ToCssClass(this Priority priority)
        {
            return _priorityCssClasses[priority];
        }
    }
}
