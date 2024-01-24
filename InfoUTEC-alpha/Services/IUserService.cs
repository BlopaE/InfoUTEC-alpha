using InfoUTEC_alpha.Models;

namespace InfoUTEC_alpha.Services
{
    public interface IUserService
    {
        Task<UserModel[]> GetUsers();
    }
}
