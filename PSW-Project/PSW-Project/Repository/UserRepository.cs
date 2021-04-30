using PSW_Project.Model;
using PSW_Project.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSW_Project.Repository
{
    public class UserRepository : IUserRepository
    {
        public User FindByLogIn(string login)
        {
            return new User() { Id = 1, Login = "Rodrigo", Senha = "porco" };
        }
    }
}
