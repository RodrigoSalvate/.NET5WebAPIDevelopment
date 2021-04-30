using PSW_Project.Model;

namespace PSW_Project.Repository.Interfaces
{
    public interface IUserRepository
    {
        User FindByLogIn(string login);
    }
}
