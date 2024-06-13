using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities.Base
{
    public class BasePerson : BaseEntity
    {
        public int DepartmentId { get; set; }

        public int RoleId { get; set; }

        [StringLength(64)]
        public string FirstName { get; set; } = null!;

        [StringLength(64)]
        public string? MiddleName { get; set; }

        [StringLength(64)]
        public string LastName { get; set; } = null!;

        [ForeignKey(nameof(DepartmentId))]
        public Department? Department { get; set; }

        [ForeignKey(nameof(RoleId))]
        public Role? Role { get; set; }

        public string FullName => string.Join(" ", LastName, FirstName, MiddleName);
    }
}
