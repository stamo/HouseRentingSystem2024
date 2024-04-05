using HouseRentingSystem.Core.Enumerations;
using HouseRentingSystem.Core.Models.Home;
using HouseRentingSystem.Core.Models.House;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync();

        Task<IEnumerable<HouseCategoryServiceModel>> AllCategoriesAsync();

        Task<bool> CategoryExistsAsync(int categoryId);

        Task<int> CreateAsync(HouseFormModel model, int agentId);

        Task<HouseQueryServiceModel> AllAsync(
            string? category = null,
            string? searchTerm = null,
            HouseSorting sorting = HouseSorting.Newest,
            int currentPage = 1,
            int housesPerPage = 1);

        Task<IEnumerable<string>> AllCategoriesNamesAsync();

        Task<IEnumerable<HouseServiceModel>> AllHousesByAgentIdAsync(int agentId);

        Task<IEnumerable<HouseServiceModel>> AllHousesByUserId(string userId);

        Task<bool> ExistsAsync(int id);

        Task<HouseDetailsServiceModel> HouseDetailsByIdAsync(int id);

        Task EditAsync(int houseId, HouseFormModel model);

        Task<bool> HasAgentWithIdAsync(int houseId, string userId);

        Task<HouseFormModel?> GetHouseFormModelByIdAsync(int id);

        Task DeleteAsync(int houseId);

        Task<bool> IsRentedAsync(int houseId);

        Task<bool> IsRentedByIUserWithIdAsync(int houseId, string userId);

        Task RentAsync(int id, string userId);

        Task LeaveAsync(int houseId, string userId);

        Task<IEnumerable<HouseServiceModel>> GetUnApprovedAsync();

        Task ApproveHouseAsync(int houseId);
    }
}
