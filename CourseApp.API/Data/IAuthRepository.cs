using System.Threading.Tasks;
using CourseApp.API.Modules;

namespace CourseApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExist(string username);
    }
}