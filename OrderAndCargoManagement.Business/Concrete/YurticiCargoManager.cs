using OrderAndCargoManagement.DataAccess.Abstract;
using OrderAndCargoManagement.DataAccess.Concrete;
using OrderAndCargoManagement.Entities;
using OrderAndCargoManagement.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderAndCargoManagement.Entities.Shared.Abstract;
using OrderAndCargoManagement.Entities.Dtos;
using AutoMapper;
using OrderAndCargoManagement.Entities.Shared.Results.Concrete;
using OrderAndCargoManagement.Entities.Shared;

namespace OrderAndCargoManagement.Business.Concrete
{
   
    public class YurticiCargoManager : IYurticiCargoService
    {
        private IYurticiCargoRepository _yurticiCargoRepository;
        private readonly IMapper _mapper;


        public YurticiCargoManager(IMapper mapper)
        {
            _yurticiCargoRepository = new YurticiCargoRepository();
            _mapper = mapper;

        }

        public YurticiCargoManager()
        {
            //_mapperı controllera alamadıgım icin bunu olusturdum
        }

        public async Task<IResult> CanceleOrder(YurticiCargoAddOrderDto yurticiCargoAddOrderDto, int id)
        {
            var foodOrder = _mapper.Map<YurticiCargo>(yurticiCargoAddOrderDto);
            foodOrder.OrderCanceledDate = DateTime.Now;
            //await _yurticiCargoRepository.CanceleOrder(yurticiCargoAddOrderDto, id);
            return new Result(ResultStatus.Pending);
        }


        public async Task<IResult> CreateOrder(YurticiCargoAddOrderDto yurticiCargoAddOrderDto)
        {
            var foodOrder = _mapper.Map<ArasCargo>(yurticiCargoAddOrderDto);
            foodOrder.OrderCreatedDate = DateTime.Now;
            //await _yurticiCargoRepository.CreateOrder(arasCargoAddOrderDto);
            return new Result(ResultStatus.Accepted);
        }

        public async Task<List<YurticiCargo>> GetAllOrders()
        {
            return await _yurticiCargoRepository.GetAllOrders();
        }

        public async Task<YurticiCargo> GetOrderById(int id)
        {
            if (id>0)
            {
                return await _yurticiCargoRepository.GetOrderById(id);

            }
            throw new Exception("id cannot be less than 1");
        }

        public async Task<YurticiCargo> GetOrderByName(string name)
        {
            if (name != null)
            {
                return await _yurticiCargoRepository.GetOrderByName(name);
            }
            throw new Exception("Order name was not found");
        }

        public async Task<YurticiCargo> UpdateOrder(YurticiCargo foodOrder)
        {
            return await UpdateOrder(foodOrder);
        }
    }
}
