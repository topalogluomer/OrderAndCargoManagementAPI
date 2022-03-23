using OrderAndCargoManagement.Entities.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAndCargoManagement.Entities.Dtos
{
    public class YurticiCargoCanceleOrderDto:DtoGetBase
    {
        [Required]
        public int Id { get; set; }
        //giyim siparisi iptali direkt olarak accepted olacak succes düşüyor.
        public override ResultStatus ResultStatus { get; set; } = ResultStatus.Accepted;
    }
}
