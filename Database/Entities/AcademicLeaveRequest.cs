using System.ComponentModel.DataAnnotations.Schema;
using Database.Entities.Base;

namespace Database.Entities
{
    public class AcademicLeaveRequest : BaseEntity
    {
        public int StudentId { get; set; }

        public string ContactPhone { get; set; } = null!;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime RequestTime { get; set; }

        public bool IsAccepted { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student? Student { get; set; }
    }
}
