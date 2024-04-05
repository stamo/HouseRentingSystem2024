using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Core.Models.Admin
{
    public class RentServiceModel
    {
        public string HouseTitle { get; set; } = string.Empty;

        public string HouseImageUrl { get; set; } = string.Empty;

        public string AgentFullName { get; set; } = string.Empty;

        public string AgentEmail { get; set; } = string.Empty;

        public string RenterFullName { get; set; } = string.Empty;

        public string RenterEmail { get; set; } = string.Empty;
    }
}
