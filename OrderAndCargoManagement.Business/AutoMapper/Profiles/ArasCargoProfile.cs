using AutoMapper;
using OrderAndCargoManagement.Entities;
using OrderAndCargoManagement.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAndCargoManagement.Business.AutoMapper.Profiles
{
    public class ArasCargoProfile:Profile
    {
        public ArasCargoProfile()
        {
            CreateMap<ArasCargoAddOrderDto, ArasCargo>().ForMember(dest=>dest.OrderCreatedDate, opt=>opt.MapFrom
            (x=>DateTime.Now));
            CreateMap<ArasCargoCanceleOrderDto, ArasCargo>().ForMember(dest => dest.OrderCanceledDate, opt => opt.MapFrom(c => DateTime.Now));
        }
    }
}
