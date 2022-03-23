using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderAndCargoManagement.Entities
{
    public class ArasCargo:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
