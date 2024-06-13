using Database.Entities.Base;

namespace Database.Entities
{
    public class ActivityCategory : BaseEntity
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
