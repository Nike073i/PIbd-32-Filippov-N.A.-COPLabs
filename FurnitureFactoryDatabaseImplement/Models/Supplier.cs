using System;
using System.ComponentModel.DataAnnotations;

namespace FurnitureFactoryDatabaseImplement.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ManufacturedFurniture { get; set; }

        [Required]
        public string OrganizationType { get; set; }

        public DateTime? LastDelivery { get; set; }
    }
}
