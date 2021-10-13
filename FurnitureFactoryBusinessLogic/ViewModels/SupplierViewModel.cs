using System;

namespace FurnitureFactoryBusinessLogic.ViewModels
{
    public class SupplierViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ManufacturedFurniture { get; set; }
        public string OrganizationType { get; set; }
        public string LastDelivery { get; set; }
    }
}
