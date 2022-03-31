using ModelGlobal_DAL.Models;

namespace ModelGlobal_DAL.Repositories
{
    public interface IAppUserRepository
    {
        AppUser Login(string email, string password);
        bool Register(string email, string password);
    }
}