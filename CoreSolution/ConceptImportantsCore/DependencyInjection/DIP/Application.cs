using System;
using System.Diagnostics;

namespace ConceptImportantsCore.DependencyInjection.DIP
{
    public class Application
    {
        private readonly IAuthentificationService _service;

        public Application(IAuthentificationService service)
        {
            _service = service;
        }

        public void Authenticate(string username,string password)
        {
            bool result = _service.Authenticate(username, password);
            if (result==true)
            {
                Debug.WriteLine("L'utilsateur est authentifié");
            }
            else
            {
                Debug.Write("L'utilisateur n'est pas authentifié");
            }
        }

        public void Authorize(string username,string password)
        {
            bool result = _service.Autorize(username, password);
            if (result == true)
            {
                Debug.WriteLine("L'utilsateur est autorisé");
            }
            else
            {
                Debug.Write("L'utilisateur n'est pas autorisé");
            }
        }
    }
}
