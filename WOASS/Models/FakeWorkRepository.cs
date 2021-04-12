using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOASS.Models
{
    public class FakeWorkRepository : IWorkRepository
    {
        public IQueryable<Work> GetAllWork()
        {
            Work[] workOrders = new Work[2];

            workOrders[0] = new Work
            {
                Id = 1,
                OrderDate = "10/28/2020",
                Priority = false,
                WorkType = "wax",
                Notes = null,
                PayStatus = true,
                PriceId = 1,
                GearId = 1,
                UserId = 1
            };

            workOrders[1] = new Work
            {
                Id = 2,
                OrderDate = "10/30/2020",
                Priority = false,
                WorkType = "basic tune",
                Notes = null,
                PayStatus = true,
                PriceId = 2,
                GearId = 2,
                UserId = 2
            };

            IEnumerable<Work> enumWork = workOrders.AsEnumerable<Work>();

            return workOrders.AsQueryable<Work>();
        }
    }
}
