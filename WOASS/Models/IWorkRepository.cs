﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WOASS.Models
{
    public interface IWorkRepository
    {
        public IQueryable<Work> GetAllWork();

    }
}