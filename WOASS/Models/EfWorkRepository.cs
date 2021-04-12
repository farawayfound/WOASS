using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOASS.Models
{
    public class EfWorkRepository : IWorkRepository
    {
        // F i e l d s   &   P r o p e r t i e s
        private AppDbContext _context;

        // C o n s t r u c t o r s
        public EfWorkRepository(AppDbContext context)
        {
            _context = context;
        }

        // M e t h o d s
        public IQueryable<Work> GetAllWork()
        {
            return _context.WorkOrders;
        }

    }
}
