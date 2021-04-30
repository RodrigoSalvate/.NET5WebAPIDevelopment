
using PSW_Project.Business.Data.VO;

namespace PSW_Project.Business.Interfaces
{
    public interface ILogInBusiness
    {
        object FindByLogIn(UserVO login);
    }
}
