using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Admin;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
    public class RentService : IRentService
    {
        private readonly IRepository repository;

        public RentService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<RentServiceModel>> AllAsync()
        {
            return await repository.AllReadOnly<House>()
                .Where(h => h.RenterId != null)
                .Include(h => h.Agent)
                .Include(h => h.Renter)
                .Select(h => new RentServiceModel()
                {
                    AgentEmail = h.Agent.User.Email,
                    AgentFullName = $"{h.Agent.User.FirstName} {h.Agent.User.LastName}",
                    HouseImageUrl = h.ImageUrl,
                    HouseTitle = h.Title,
                    RenterEmail = h.Renter != null ? h.Renter.Email : string.Empty,
                    RenterFullName = h.Renter != null ? $"{h.Renter.FirstName} {h.Renter.LastName}" : string.Empty
                })
                .ToListAsync();
        }
    }
}
