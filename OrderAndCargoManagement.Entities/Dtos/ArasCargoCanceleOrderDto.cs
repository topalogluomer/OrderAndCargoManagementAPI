using OrderAndCargoManagement.Entities.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAndCargoManagement.Entities.Dtos
{
    public class ArasCargoCanceleOrderDto: DtoGetBase
    {
        [Required]
        public int Id { get; set; }
        //eğer gıda siparisi iptal isteği gelirse otomatik pendinge düsüyor ve buradan yöneticiye gidecek
        public override ResultStatus ResultStatus { get; set; } = ResultStatus.Pending;

    }
}
