using System.ComponentModel.DataAnnotations;

namespace FurnitureFactoryDatabaseImplement.Models
{
    public class OrganizationType
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
