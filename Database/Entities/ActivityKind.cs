using Database.Entities.Base;

namespace Database.Entities
{
    public class ActivityKind : BaseEntity
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public bool InPlan { get; set; }
    }
}
