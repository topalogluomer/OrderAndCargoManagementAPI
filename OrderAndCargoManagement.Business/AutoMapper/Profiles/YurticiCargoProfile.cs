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
    public class YurticiCargoProfile : Profile
    {
        public YurticiCargoProfile()
        {
            CreateMap<YurticiCargoAddOrderDto,YurticiCargo>().ForMember(dest => dest.OrderCreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<YurticiCargoCanceleOrderDto, YurticiCargo>().ForMember(dest => dest.OrderCanceledDate, opt => opt.MapFrom(c => DateTime.Now));

        }
    }
}
