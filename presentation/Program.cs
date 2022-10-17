
using InyeccionDeDependeciasCSharp.data;
using InyeccionDeDependeciasCSharp.domain.service;





AuthRepositoryImpl repository = new();
AuthService auth = new AuthService(repository);

try
{
    String email = "email";
    String password = "password";

    Console.WriteLine(auth.SignIn(email, password));

}
catch (Exception e)
{
    Console.WriteLine(e);
}