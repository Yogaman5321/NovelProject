using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
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
            string query = "SELECT EncryptedPassword FROM Users WHERE Username = @Username";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };

            using (var reader = DatabaseHelper.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    string storedEncryptedPassword = reader.GetString(0);
                    return BCrypt.Net.BCrypt.Verify(password, storedEncryptedPassword);
                }
                else
                {
                    return false; // Username not found
                }
            }
        }

        public bool TryCreateAccount(string username, string password)
        {
            string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            var checkParams = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };

            int userCount = DatabaseHelper.ExecuteScalar<int>(checkQuery, checkParams);
            if (userCount > 0)
            {
                return false; // Username already exists
            }

            string insertQuery = "INSERT INTO Users (Username, EncryptedPassword) VALUES (@Username, @EncryptedPassword)";


            var insertParams = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@EncryptedPassword", BCrypt.Net.BCrypt.HashPassword(password)),
            };
            int rowsAffected = DatabaseHelper.ExecuteNonQuery(insertQuery, insertParams);
            return rowsAffected > 0; // Return true if the account was created successfully

        }
    }
}
