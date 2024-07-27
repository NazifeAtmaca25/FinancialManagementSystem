using Financal_Management_System.dao;
using Financal_Management_System.enumacation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financal_Management_System.controller
{
    
    public class Controller
    {
        Repository repository;
        
        public Controller() {
            repository = new Repository();

        }

        public LoginState login(string userId, string password) {
        if (!string.IsNullOrEmpty(userId) && !string.IsNullOrEmpty(password))
            {
                LoginState result= repository.login(userId, password);
                return result;
            }
            else
            {
                return LoginState.incompleteParameter;
            }
        }
    }
}
