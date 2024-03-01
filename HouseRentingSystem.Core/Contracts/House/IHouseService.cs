using HouseRentingSystem.Core.Models.Home;

namespace HouseRentingSystem.Core.Contracts.House
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHouses();
    }
}
