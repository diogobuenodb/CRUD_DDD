using BRQ.Domain.Interfaces.Domain;
using BRQ.Domain.Repositories;
using BRQ.Domain.Services;
using BRQ.InfraStructure.Data.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace BRQ.UI.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            // Dominio
            container.RegisterType<IBRQ, ServiceBRQ>();


            //Infra
            container.RegisterType<IRepositoriesUser, RepositoriesUser>();
                      

            container.Resolve<IBRQ>();
            //container.Resolve<IRepositorioRelatorioVendasCupom>();
            //container.Resolve<IRelatorioLista>();
            //container.Resolve<IRepositorioRelatorioItensDePedido>();
            //container.Resolve<IRepositorioRelatorioVendasCupom>();
            //container.Resolve<IRepositorioGetFileCCR>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}