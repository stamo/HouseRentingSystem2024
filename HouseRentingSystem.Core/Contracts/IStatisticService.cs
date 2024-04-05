using HouseRentingSystem.Core.Models.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Core.Contracts
{
    public interface IStatisticService
    {
        Task<StatisticServiseModel> TotalAsync();
    }
}
