using Database.Entities.Base;

namespace Database.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}
