using System.ComponentModel;

namespace FurnitureFactoryBusinessLogic.ViewModels
{
    public class OrganizationTypeViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
    }
}
