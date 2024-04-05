using HouseRentingSystem.Core.Models.Admin;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IRentService
    {
        Task<IEnumerable<RentServiceModel>> AllAsync();
    }
}
