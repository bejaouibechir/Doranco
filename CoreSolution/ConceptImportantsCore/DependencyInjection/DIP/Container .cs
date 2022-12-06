using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptImportantsCore.DependencyInjection.DIP
{
    public  class Container
    {

        public void TouteLAffaire()
        {
            IAuthentificationService service = new AuthentificationService1();
            Application application = new Application(service);
            //Test d'authentification
            application.Authenticate("user1", "pass1");
            
            application.Authenticate("user1", "pass2");
            
            application.Authenticate("user4", "pass100");

            //Test de l'autorisation 
            application.Authorize("user1", "pass1"); //Teste si l'utilisateur est un admin ou pas

            application.Authorize("user2", "pass2"); //Teste si l'utilisateur est un admin ou pas
        }
    }
}
