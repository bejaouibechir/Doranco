namespace ConceptImportantsCore.DependencyInjection.DIP
{
    public interface IAuthentificationService
    {
        bool Authenticate(string login, string password);
        bool Autorize(string username, string password);
    }
}