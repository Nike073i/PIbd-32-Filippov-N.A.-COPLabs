using FurnitureFactoryBusinessLogic.BindingModels;
using FurnitureFactoryBusinessLogic.Interfaces;
using FurnitureFactoryBusinessLogic.ViewModels;
using FurnitureFactoryDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureFactoryDatabaseImplement.Implements
{
    public class OrganizationTypeStorage : IOrganizationTypeStorage
    {
        public List<OrganizationTypeViewModel> GetFullList()
        {
            using (var context = new FurnitureFactoryDatabase())
            {
                return context.OrganizationTypes.Select(rec => new OrganizationTypeViewModel
                {
                    Id = rec.Id,
                    Name = rec.Name
                })
                .ToList();
            }
        }

        public OrganizationTypeViewModel GetElement(OrganizationTypeBindingModel model)
        {
            if (model is null)
            {
                return null;
            }
            using (var context = new FurnitureFactoryDatabase())
            {
                var organizationType = context.OrganizationTypes
                .FirstOrDefault(rec => rec.Name == model.Name || rec.Id == model.Id);
                return organizationType is null ? null :
                new OrganizationTypeViewModel
                {
                    Id = organizationType.Id,
                    Name = organizationType.Name
                };
            }
        }

        public void Insert(OrganizationTypeBindingModel model)
        {
            using (var context = new FurnitureFactoryDatabase())
            {
                OrganizationType newOrganizationType = new OrganizationType
                {
                    Name = model.Name
                };
                context.OrganizationTypes.Add(newOrganizationType);
                context.SaveChanges();
            }
        }

        public void Update(OrganizationTypeBindingModel model)
        {
            using (var context = new FurnitureFactoryDatabase())
            {
                var organizationType = context.OrganizationTypes.FirstOrDefault(rec => rec.Id == model.Id);
                if (organizationType is null)
                {
                    throw new Exception("Тип операции не найден");
                }
                organizationType.Name = model.Name;
                context.SaveChanges();
            }
        }

        public void Delete(OrganizationTypeBindingModel model)
        {
            using (var context = new FurnitureFactoryDatabase())
            {
                var organizationType = context.OrganizationTypes.FirstOrDefault(rec => rec.Id == model.Id);
                if (organizationType is null)
                {
                    throw new Exception("Тип операции не найден");
                }
                else
                {
                    context.OrganizationTypes.Remove(organizationType);
                    context.SaveChanges();
                }
            }
        }
    }
}
