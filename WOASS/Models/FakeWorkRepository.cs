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
            Work[] workOrders = new Work[5];
            workOrders[0] = new Work
            {
                WorkId = 1,
                OrderDate = "10/27/2020",
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
                WorkId = 2,
                OrderDate = "10/28/2020",
                Priority = false,
                WorkType = "base grind",
                Notes = null,
                PayStatus = true,
                PriceId = 2,
                GearId = 2,
                UserId = 2
            };

            workOrders[2] = new Work
            {
                WorkId = 3,
                OrderDate = "10/29/2020",
                Priority = false,
                WorkType = "base grind",
                Notes = null,
                PayStatus = true,
                PriceId = 2,
                GearId = 3,
                UserId = 2
            };

            workOrders[3] = new Work
            {
                WorkId = 4,
                OrderDate = "10/30/2020",
                Priority = false,
                WorkType = "basic tune",
                Notes = null,
                PayStatus = true,
                PriceId = 3,
                GearId = 4,
                UserId = 3
            };
            workOrders[4] = new Work
            {
                WorkId = 5,
                OrderDate = "11/1/2020",
                Priority = false,
                WorkType = "basic tune",
                Notes = null,
                PayStatus = true,
                PriceId = 3,
                GearId = 4,
                UserId = 3
            };
            return workOrders.AsQueryable<Work>();
        }
    }
}
