using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PSW_Project.Business.Data.VO;
using PSW_Project.Business.Interfaces;
namespace PSW_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private ILogInBusiness _logInBusiness;

        public LogInController(ILogInBusiness logInBusiness)
        {
            _logInBusiness = logInBusiness;
        }

        [AllowAnonymous]
        [HttpPost]
        public object Post([FromBody] UserVO user)
        {
            if (user == null) return BadRequest();

            return _logInBusiness.FindByLogIn(user);
        }
    }
}
