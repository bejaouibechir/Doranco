using System;
using System.Diagnostics;
using Unity;

namespace ConceptImportantsCore.DependencyInjection.Unity
{
    public class Application
    {
        IUnityContainer conteneur = new UnityContainer();

        public Application()
        {
            conteneur.RegisterType<Service1>();
            conteneur.RegisterType<Service2>();
            conteneur.RegisterType<Service3>();
        }
        public void ConsommerService(ServiceKind kind)
        {
            IService service;
            try
            {
                switch (kind)
                {
                    case ServiceKind.Srv1:
                        service = conteneur.Resolve<Service1>();
                        break;
                    case ServiceKind.Srv2:
                        service = conteneur.Resolve<Service2>();
                        break;
                    case ServiceKind.Srv3:
                        service = conteneur.Resolve<Service3>();
                        break;
                    default:
                        throw new ArgumentException("Le service n'est pas définit");

                }
                service.fonctionalité();
            }
            catch (ArgumentException erreur)
            {
                Debug.WriteLine(erreur.Message);
            }
        }
    }

    
}
