using FurnitureFactoryBusinessLogic.BindingModels;
using FurnitureFactoryBusinessLogic.Interfaces;
using FurnitureFactoryBusinessLogic.ViewModels;
using FurnitureFactoryDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureFactoryDatabaseImplement.Implements
{
    public class SupplierStorage : ISupplierStorage
    {
        public List<SupplierViewModel> GetFullList()
        {
            using (var context = new FurnitureFactoryDatabase())
            {
                return context.Suppliers.Select(rec => new SupplierViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    ManufacturedFurniture = rec.ManufacturedFurniture,
                    OrganizationType = rec.OrganizationType,
                    LastDelivery = (rec.LastDelivery.HasValue) ? rec.LastDelivery.Value.ToString("dd.MM.yyyy") : "Поставок не было"
                })
                .ToList();
            }
        }

        public List<SupplierViewModel> GetFilteredList(SupplierBindingModel model)
        {
            if (model is null)
            {
                return null;
            }
            using (var context = new FurnitureFactoryDatabase())
            {
                return context.Suppliers
                .Where(rec => rec.Name.Equals(model.Name)
                    || model.DateFrom.HasValue && model.DateTo.HasValue && rec.LastDelivery.Value.Date >= model.DateFrom.Value.Date && rec.LastDelivery.Value.Date <= model.DateTo.Value.Date)
                .Select(rec => new SupplierViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name,
                    ManufacturedFurniture = rec.ManufacturedFurniture,
                    OrganizationType = rec.OrganizationType,
                    LastDelivery = (rec.LastDelivery.HasValue) ? rec.LastDelivery.Value.ToString("dd.MM.yyyy") : "Поставок не было"
                })
                .ToList();
            }
        }

        public SupplierViewModel GetElement(SupplierBindingModel model)
        {
            if (model is null)
            {
                return null;
            }
            using (var context = new FurnitureFactoryDatabase())
            {
                var supplier = context.Suppliers
                .FirstOrDefault(rec => rec.Name == model.Name || rec.Id == model.Id);
                return supplier is null ? null :
                new SupplierViewModel
                {
                    Id = supplier.Id,
                    Name = supplier.Name,
                    ManufacturedFurniture = supplier.ManufacturedFurniture,
                    OrganizationType = supplier.OrganizationType,
                    LastDelivery = (supplier.LastDelivery.HasValue) ? supplier.LastDelivery.Value.ToString("dd.MM.yyyy") : "Поставок не было"
                };
            }
        }

        public void Insert(SupplierBindingModel model)
        {
            using (var context = new FurnitureFactoryDatabase())
            {
                context.Suppliers.Add(CreateModel(model, new Supplier()));
                context.SaveChanges();
            }
        }

        public void Update(SupplierBindingModel model)
        {
            using (var context = new FurnitureFactoryDatabase())
            {
                var supplier = context.Suppliers.FirstOrDefault(rec => rec.Id == model.Id);
                if (supplier is null)
                {
                    throw new Exception("Поставщик не найден");
                }
                CreateModel(model, supplier);
                context.SaveChanges();
            }
        }

        public void Delete(SupplierBindingModel model)
        {
            using (var context = new FurnitureFactoryDatabase())
            {
                var supplier = context.Suppliers.FirstOrDefault(rec => rec.Id == model.Id);
                if (supplier is null)
                {
                    throw new Exception("Поставщик не найден");
                }

                context.Suppliers.Remove(supplier);
                context.SaveChanges();
            }
        }

        private Supplier CreateModel(SupplierBindingModel model, Supplier supplier)
        {
            supplier.Name = model.Name;
            supplier.ManufacturedFurniture = model.ManufacturedFurniture;
            supplier.OrganizationType = model.OrganizationType;
            supplier.LastDelivery = model.LastDelivery;
            return supplier;
        }
    }
}
