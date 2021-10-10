using System;

namespace FurnitureFactoryBusinessLogic.BindingModels
{
    public class SupplierBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string ManufacturedFurniture { get; set; }
        public string OrganizationType { get; set; }
        public DateTime? LastDelivery { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
