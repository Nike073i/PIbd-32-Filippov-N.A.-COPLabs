using FurnitureFactoryBusinessLogic.BindingModels;
using FurnitureFactoryBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace FurnitureFactoryBusinessLogic.Interfaces
{
    public interface IOrganizationTypeStorage
    {
        List<OrganizationTypeViewModel> GetFullList();
        OrganizationTypeViewModel GetElement(OrganizationTypeBindingModel model);
        void Insert(OrganizationTypeBindingModel model);
        void Update(OrganizationTypeBindingModel model);
        void Delete(OrganizationTypeBindingModel model);
    }
}
