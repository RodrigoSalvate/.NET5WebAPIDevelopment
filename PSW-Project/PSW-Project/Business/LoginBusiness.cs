using PSW_Project.Business.Data.VO;
using PSW_Project.Business.Interfaces;
using PSW_Project.Repository.Interfaces;
using PSW_Project.Security.Configuration;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;

namespace PSW_Project.Business
{
    public class LoginBusiness : ILogInBusiness
    {
        public IUserRepository _repository;
        private SigningConfiguration _signingConfigurations;
        private TokenConfiguration _tokenConfiguration;

        public LoginBusiness(SigningConfiguration signingConfiguration, TokenConfiguration tokenConfiguration, IUserRepository repository)
        {
            _signingConfigurations = signingConfiguration;
            _tokenConfiguration = tokenConfiguration;
            _repository = repository;
        }

        public object FindByLogIn(UserVO user)
        {
            bool credentialsValid = false;

            if (user != null && !string.IsNullOrEmpty(user.Login))
            {
                var userBanco = _repository.FindByLogIn(user.Login);
                credentialsValid = (userBanco != null && user.Login == userBanco.Login && user.Senha == userBanco.Senha);
            }

            if (credentialsValid)
            {
                ClaimsIdentity identity = new ClaimsIdentity
                (
                    new GenericIdentity(user.Login, "Login"),
                    new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName,user.Login)
                    }
                );

                DateTime createDate = DateTime.Now;
                DateTime expirationDate = createDate + TimeSpan.FromSeconds(_tokenConfiguration.Seconds);

                var handler = new JwtSecurityTokenHandler();
                string token = createToken(identity, createDate, expirationDate, handler);

                return new
                {
                    autenticated = true,
                    created = createDate.ToString("yyyy-MM-dd HH:mm:ss"),
                    expiration = expirationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                    accessToken = token,
                    message = "OK"
                };
            }
            else
            {
                return new
                {
                    autenticated = false,
                    message = "Failed to authenticate"
                };
            }
        }

        private string createToken(ClaimsIdentity identity, DateTime createDate, DateTime expirationDate, JwtSecurityTokenHandler handler)
        {
            var securityToken = handler.CreateToken(new Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor()
            {
                Issuer = _tokenConfiguration.Issuer,
                Audience = _tokenConfiguration.Audience,
                SigningCredentials = _signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = createDate,
                Expires = expirationDate
            });

            var token = handler.WriteToken(securityToken);

            return token;
        }
    }
}





