using InyeccionDeDependeciasCSharp.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependeciasCSharp.domain.repository
{
    public interface IAuthRepository
    {
        String SignIn(AuthModel data);
    }
}
