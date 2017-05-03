using Business;
using Domain.Interfaces;
using Repository;
using SimpleInjector;

namespace SimpleInjectorIOC
{
    public static class SIContainer
    {
        public static Container RegisterServices()
        {
            var container = new Container();

            //Registrando as Implementações
            container.Register<IClientService, ClientService>();
            container.Register<IClientRepository, ClientRepository>();

            container.Verify();
            return container;
        }
    }
}
