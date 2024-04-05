using HouseRentingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Areas.Admin.Controllers
{
    public class RentController : AdminBaseController
    {
        private readonly IRentService rentService;

        public RentController(IRentService _rentService)
        {
            rentService = _rentService;
        }
        
        public async Task<IActionResult> All()
        {
            var model = await rentService.AllAsync();
            
            return View(model);
        }
    }
}
