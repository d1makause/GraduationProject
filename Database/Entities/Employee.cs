using System.ComponentModel.DataAnnotations.Schema;
using Database.Entities.Base;

namespace Database.Entities
{
    public class Employee : BasePerson
    {
        public int PulpitId { get; set; }

        public string Email { get; set; } = null!;

        public int Experience { get; set; }

        public string Position { get; set; } = null!;

        [ForeignKey(nameof(PulpitId))]
        public Pulpit? Pulpit { get; set; }
    }
}
