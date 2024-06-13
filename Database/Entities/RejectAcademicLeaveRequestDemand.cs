using System.ComponentModel.DataAnnotations.Schema;
using Database.Entities.Base;

namespace Database.Entities
{
    public class RejectAcademicLeaveRequestDemand : BaseEntity
    {
        public int AcademicLeaveRequestId { get; set; }

        public DateTime RequestTime { get; set; }

        [ForeignKey(nameof(AcademicLeaveRequestId))]
        public AcademicLeaveRequest? AcademicLeaveRequest { get; set; }
    }
}
