using System.ComponentModel.DataAnnotations.Schema;
using Database.Entities.Base;

namespace Database.Entities
{
    public class Group : BaseEntity
    {
        public string Name { get; set; } = null!;

        public int SpecialityId { get; set; }

        public int Course { get; set; }

        [ForeignKey(nameof(SpecialityId))]
        public Speciality? Speciality { get; set; }
    }
}
