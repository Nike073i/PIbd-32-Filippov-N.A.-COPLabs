using FurnitureFactoryBusinessLogic.BusinessLogics;
using FurnitureFactoryBusinessLogic.Interfaces;
using FurnitureFactoryDatabaseImplement.Implements;
using System;
using System.Windows.Forms;
using FurnitureFactoryBusinessLogic.PluginLogics.Managers;
using TelegramPlugin;
using Unity;
using Unity.Lifetime;

namespace FurnitureFactoryView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<ISupplierStorage, SupplierStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrganizationTypeStorage, OrganizationTypeStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<SupplierLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<OrganizationTypeLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportPluginManager>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<MessengerPluginManager>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<TelegramMessenger>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
