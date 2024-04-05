using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Admin;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace HouseRentingSystem.Areas.Admin.Controllers
{
    public class HouseController : AdminBaseController
    {
        private readonly IHouseService houseService;

        private readonly IAgentService agentService;

        public HouseController(
            IHouseService _houseService,
            IAgentService _agentService)
        {
            houseService = _houseService;
            agentService = _agentService;
        }
        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();
            int agentId = await agentService.GetAgentIdAsync(userId) ?? 0;
            var myHouses = new MyHousesViewModel()
            {
                AddedHouses = await houseService.AllHousesByAgentIdAsync(agentId),
                RentedHouses = await houseService.AllHousesByUserId(userId)
            };

            return View(myHouses);
        }

        [HttpGet]
        public async Task<IActionResult> Approve()
        {
            var model = await houseService.GetUnApprovedAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int houseId)
        {
            await houseService.ApproveHouseAsync(houseId);

            return RedirectToAction(nameof(Approve));
        }
    }
}
