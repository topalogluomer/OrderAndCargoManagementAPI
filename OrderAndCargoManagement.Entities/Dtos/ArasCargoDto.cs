using OrderAndCargoManagement.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAndCargoManagement.Entities.Dtos
{
    public class ArasCargoDto: DtoGetBase
    {
        public ArasCargo ArasCargo { get; set; }

    }
}
