using InfoUTEC_alpha.Models;

namespace InfoUTEC_alpha.Services
{
    public class UserService : IUserService
    {
        public Task<UserModel[]> GetUsers()
        {
            UserModel userModel = new UserModel
            {
                Id = 1,
                Username = "Test",
                Password = "Test",
            };

            return Task.FromResult(new[] { userModel });
        }
    }
}
