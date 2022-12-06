using System;

namespace ConceptImportantsCore.DependencyInjection.DIP
{
    public class AuthentificationService1 : IAuthentificationService
    {
        People _people;
        public AuthentificationService1()
        {
            _people = new People();
        }
        public bool Authenticate(string login, string password)
        {

            foreach (var user in _people)
            {
                if (login == "user1")
                {
                    if (password == "pass1")
                    {
                        return true;
                    }
                }
                else if (login == "user2")
                {
                    if (password == "pass2")
                    {
                        return true;
                    }
                }
                else if (login == "user3")
                {
                    if (password == "pass3")
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public bool Autorize(string username, string password)
        {
            User current = new User { Login = username, Password = password };
            if (Authenticate(username, password) == true)
            {
                User temp = _people.SingleOrDefault(u => u.Login == username);
                if (temp.Role == "admin")
                {
                    return true;
                }
            }
            else
            {
                return false;
            }

            return false;
        }

    }

    #region Model de données + la source des données 
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }
    }

    public class People : List<User>
    {
        public People()
        {
            Add(new User {Login="user1", Password="pass1",Role="admin" });
            Add(new User { Login = "user2", Password = "pass2",Role = "visitor" });
            Add(new User { Login = "user3", Password = "pass3",Role = "visitor" });
        }
    }
    #endregion
}
