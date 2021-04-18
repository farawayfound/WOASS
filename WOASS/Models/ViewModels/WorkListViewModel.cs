using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WOASS.Models;

namespace WOASS.Models.ViewModels
{
    public class WorkListViewModel
    {

        public IEnumerable<Work> WorkOrders { get; set; }

        /*InvalidOperationException: The model item passed into the ViewDataDictionary is of type 'Microsoft.EntityFrameworkCore.Internal.InternalDbSet`1[WOASS.Models.Work]', 
         * but this ViewDataDictionary instance requires a model item of type 'WOASS.Models.ViewModels.WorkListViewModel'.*/
        
    }
}
