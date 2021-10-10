using FurnitureFactoryBusinessLogic.BindingModels;
using FurnitureFactoryBusinessLogic.Interfaces;
using FurnitureFactoryBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace FurnitureFactoryBusinessLogic.BusinessLogics
{
    public class OrganizationTypeLogic
    {
        private readonly IOrganizationTypeStorage _organizationTypeStorage;

        public OrganizationTypeLogic(IOrganizationTypeStorage organizationTypeStorage)
        {
            _organizationTypeStorage = organizationTypeStorage;
        }

        public List<OrganizationTypeViewModel> Read(OrganizationTypeBindingModel model)
        {
            if (model is null)
            {
                return _organizationTypeStorage.GetFullList();
            }
            return new List<OrganizationTypeViewModel> { _organizationTypeStorage.GetElement(model) };
        }

        public void CreateOrUpdate(OrganizationTypeBindingModel model)
        {
            var organizationType = _organizationTypeStorage.GetElement(new OrganizationTypeBindingModel
            {
                Name = model.Name
            });
            if (!(organizationType is null) && !organizationType.Id.Equals(model.Id))
            {
                throw new Exception("Уже есть тип организации с таким названием");
            }
            if (model.Id.HasValue)
            {
                _organizationTypeStorage.Update(model);
            }
            else
            {
                _organizationTypeStorage.Insert(model);
            }
        }
        public void Delete(OrganizationTypeBindingModel model)
        {
            var organizationType = _organizationTypeStorage.GetElement(new OrganizationTypeBindingModel
            {
                Id = model.Id
            });
            if (organizationType is null)
            {
                throw new Exception("Тип организации не найден");
            }
            _organizationTypeStorage.Delete(model);
        }
    }
}
