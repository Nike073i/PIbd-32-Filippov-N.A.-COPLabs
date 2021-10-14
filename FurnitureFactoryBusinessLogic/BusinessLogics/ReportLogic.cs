using System;
using FurnitureFactoryBusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Linq;
using ClassLibraryComponentsFilippov.HelperModels;
using FurnitureFactoryBusinessLogic.BindingModels;

namespace FurnitureFactoryBusinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        private readonly ISupplierStorage _supplierStorage;
        private readonly IOrganizationTypeStorage _organizationTypeStorage;

        public ReportLogic(ISupplierStorage supplierStorage, IOrganizationTypeStorage organizationTypeStorage)
        {
            _supplierStorage = supplierStorage;
            _organizationTypeStorage = organizationTypeStorage;
        }

        public List<string> GetArraySupplierWithManufacturedFurnitureForYear()
        {
            List<string> resultArray = new List<string>();
            var list = _supplierStorage.GetFilteredList(new SupplierBindingModel
            {
                DateFrom = DateTime.Now.AddYears(-1),
                DateTo = DateTime.Now
            });
            var items = list.Select(x => new { x.Name, x.ManufacturedFurniture });
            foreach (var item in items)
            {
                resultArray.Add(item.Name + ": " + item.ManufacturedFurniture);
            }
            return resultArray;
        }
    }
}
