using HouseRentingSystem.Core.Models.Admin.User;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IUserService
    {
        Task<string> UserFullNameAsync(string userId);

        Task<IEnumerable<UserServiceModel>> AllAsync();
    }
}
