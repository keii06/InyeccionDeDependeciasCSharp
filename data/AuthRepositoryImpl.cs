using InyeccionDeDependeciasCSharp.domain.model;
using InyeccionDeDependeciasCSharp.domain.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependeciasCSharp.data
{
    public class AuthRepositoryImpl : IAuthRepository
    {
        public string SignIn(AuthModel data)
        {
            if (data.Email == "email")
            {
                if (data.Password == "password")
                {
                    return "Inicio correcto";
                }
                else
                {
                    return "Contraseña incorrecta";
                }
            }
            else
            {
                return "Email incorrecto";
            }
        }
    }
}
