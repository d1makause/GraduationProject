using System.ComponentModel.DataAnnotations.Schema;
using Database.Entities.Base;

namespace Database.Entities
{
    public class Event : BaseEntity
    {
        public int ActivityKindId { get; set; }

        public int ActivityCategoryId { get; set; }

        public string Name { get; set; } = null!;

        public uint ParticipantsAmount { get; set; }

        public string Description { get; set; } = null!;

        public DateTime StartDate { get; set; }

        public bool IsCompleted { get; set; }

        public int[] EmployeeIds { get; set; } = null!;

        public int[] StudentIds { get; set; } = null!;

        [ForeignKey(nameof(ActivityKindId))]
        public ActivityKind? ActivityKind { get; set; }

        [ForeignKey(nameof(ActivityCategoryId))]
        public ActivityCategory? ActivityCategory { get; set; }
    }
}
