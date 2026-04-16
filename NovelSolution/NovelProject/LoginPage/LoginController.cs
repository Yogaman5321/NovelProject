using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NovelProject.Models;

namespace NovelProject.LoginPage
{
    public class LoginController
    {
        public LoginObserver observer;

        public LoginController(LoginObserver observer)
        {
            this.observer = observer;
        }


        public void HandleEvents(LoginState s, string username, string encryptedPassword)
        {
            switch (s)
            {
                case LoginState.TryLoginAccount:
                    if (TryLoginAccount(username, encryptedPassword))
                    {
                        observer(LoginState.SucceedLogin);
                    }
                    else
                    {
                        observer(LoginState.FailLogin);
                    }
                    break;
                case LoginState.TryCreateAccount:
                    if (TryCreateAccount(username, encryptedPassword))
                    {
                        observer(LoginState.SucceedCreate);
                    }
                    else
                    {
                        observer(LoginState.FailCreate);
                    }
                    break;
                case LoginState.LoginAsGuest:
                    observer(LoginState.LoginAsGuest);
                    break;
                default:
                    break;
            }
        }

        public bool TryLoginAccount(string username, string password)
        {
            using (var context = new ProjectDatabaseContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username);
                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.EncryptedPassword))
                {
                    return true;
                }
            }
            return false;
        }

        public bool TryCreateAccount(string username, string password)
        {
            using (var context = new ProjectDatabaseContext())
            {
                if (context.Users.Any(u => u.Username == username))
                {
                    return false; // Username already exists
                }
                var newUser = new UserAccount
                {
                    Username = username,
                    EncryptedPassword = password,
                    AccountCreatedDate = DateTime.Now
                };
                context.Users.Add(newUser);
                context.SaveChanges();
                return true; // Account created successfully
            }

        }
    }
}
