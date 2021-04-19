using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOASS.Models
{
    public interface IWorkRepository
    {
        //  R e a d
        public IQueryable<Work> GetAllWork();
        Work GetWorkById(int workId);
        IQueryable<Work> GetWorkByKeyword(string keyword);

        //  U p d a t e

        public Work UpdateWork(Work work);
    }
}
