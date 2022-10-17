using InyeccionDeDependeciasCSharp.domain.model;
using InyeccionDeDependeciasCSharp.domain.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependeciasCSharp.domain.service
{
    public class AuthService
    {
        IAuthRepository repository;

        public AuthService(IAuthRepository repository)
        {
            this.repository = repository;
        }

        public string SignIn(String email, String password)
        {
            AuthModel data = new(email, password);
            return repository.SignIn(data);
        }
    }
}
