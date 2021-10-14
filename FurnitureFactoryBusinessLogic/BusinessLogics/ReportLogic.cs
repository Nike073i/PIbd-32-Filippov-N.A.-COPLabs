using ComponentLibrary.models;
using FurnitureFactoryBusinessLogic.BindingModels;
using FurnitureFactoryBusinessLogic.HelperModels;
using FurnitureFactoryBusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var list = _supplierStorage.GetFilteredList(new SupplierBindingModel
            {
                DateFrom = DateTime.Now.AddYears(-1),
                DateTo = DateTime.Now
            });
            var items = list.Select(x => new { x.Name, x.ManufacturedFurniture });
            return items.Select(item => item.Name + ": " + item.ManufacturedFurniture).ToList();
        }

        public List<SeriesInfo> GetListSuppliersCount()
        {
            List<SeriesInfo> resultList;
            var list = _supplierStorage.GetFilteredList(new SupplierBindingModel
            {
                DateFrom = DateTime.Now.AddYears(-1),
                DateTo = DateTime.Now
            });
            resultList = list.GroupBy(x => x.OrganizationType).Select(x => new SeriesInfo(x.Key, x.Count()))
                .ToList();

            return resultList;
        }

        public TableDataConfig GetSupplierForTable()
        {
            var result = new TableDataConfig
            {
                Data = _supplierStorage.GetFilteredList(new SupplierBindingModel
                {
                    DateFrom = DateTime.Now.AddYears(-1),
                    DateTo = DateTime.Now
                }),
                PropertiesOrder = new List<string> { "Id", "Name", "OrganizationType", "LastDelivery" },
                Headers = new List<string> { "Id", "Название", "Тип организации", "Дата последней поставки" },
                ColumnsWidth = new List<int> { 15, 25, 20, 30 },
                RowsHeight = new List<int> { 15 }
            };
            result.Data.ForEach(x => result.RowsHeight.Add(15));
            return result;
        }
    }
}
