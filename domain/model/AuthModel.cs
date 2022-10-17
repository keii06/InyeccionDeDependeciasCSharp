using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependeciasCSharp.domain.model
{
    public class AuthModel
    {
        public String Email { get; set; }
        public  String Password { get; set; }

        public AuthModel(string email, string password)
        {
            this.Email = email;
            this.Password = password;

            Validate();
        }

        public void Validate()
        {
            ValidateEmail(this.Email);
            ValidatePassword(this.Password);
        }

        public static void ValidateEmail(String field)
        {
            ValidateEmptyField(field);
        }

        public static void ValidatePassword(String field)
        {
            ValidateEmptyField(field);
        }

        public static void ValidateEmptyField(String field)
        {
            if (field == "")
            {
                throw new Exception("El campo se encuentra vacío");
            }
        }




    }
}
