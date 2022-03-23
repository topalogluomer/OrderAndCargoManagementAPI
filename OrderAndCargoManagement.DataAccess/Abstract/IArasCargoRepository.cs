using OrderAndCargoManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAndCargoManagement.DataAccess.Abstract
{
    public interface IArasCargoRepository
    {
        Task<List<ArasCargo>> GetAllOrders();
        Task<ArasCargo> GetOrderById(int id);
        Task<ArasCargo> GetOrderByName(string name);
        Task<ArasCargo> CreateOrder(ArasCargo clothingOrder);
        //Task<IResult> CreateOrder(ArasCargoAddOrderDto arasCargoAddOrderDto);
        //Task<IResult> CanceleOrder(ArasCargoCanceleOrderDto arasCargoCanceleOrderDto, int id);

    }
}
