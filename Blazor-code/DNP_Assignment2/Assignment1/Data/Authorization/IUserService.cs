using Assignment1.Models.Authorization;
using System.Threading.Tasks;

namespace Assignment1.Data.Authorization
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string passWord);
    }
}
