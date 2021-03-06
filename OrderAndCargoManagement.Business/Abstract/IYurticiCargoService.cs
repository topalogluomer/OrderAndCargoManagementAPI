using OrderAndCargoManagement.Entities;
using OrderAndCargoManagement.Entities.Dtos;
using OrderAndCargoManagement.Entities.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAndCargoManagement.Business.Abstract
{
    public interface IYurticiCargoService
    {
        Task<List<YurticiCargo>> GetAllOrders();
        Task<YurticiCargo> GetOrderById(int id);
        Task<YurticiCargo> GetOrderByName(string name);
        //Task<YurticiCargo> CreateOrder(YurticiCargo foodOrder);
        //Task<YurticiCargo> UpdateOrder(YurticiCargo foodOrder);
        //Task CanceleOrder(int id);
        Task<IResult> CreateOrder(YurticiCargoAddOrderDto yurticiCargoAddOrderDto);
        Task<IResult> CanceleOrder(YurticiCargoAddOrderDto yurticiCargoAddOrderDto, int id);
        Task CanceleOrder(YurticiCargoCanceleOrderDto yurticiCargoCanceleOrderDto, int id);
    }
}
