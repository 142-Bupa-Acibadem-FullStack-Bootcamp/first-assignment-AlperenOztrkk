using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Dto
{
   public  class DtoCustomerDemographcs:DtoBase
    {
        public DtoCustomerDemographcs()
        {

        }
        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

    }
}
