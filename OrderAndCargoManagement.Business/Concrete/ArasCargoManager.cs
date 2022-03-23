using OrderAndCargoManagement.DataAccess.Abstract;
using OrderAndCargoManagement.DataAccess.Concrete;
using OrderAndCargoManagement.Entities;
using OrderAndCargoManagement.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderAndCargoManagement.DataAccess.Concrete.Repositories;
using OrderAndCargoManagement.Entities.Dtos;
using AutoMapper;
using OrderAndCargoManagement.Entities.Shared.Results.Concrete;
using OrderAndCargoManagement.Entities.Shared.Abstract;
using OrderAndCargoManagement.Entities.Shared;

namespace OrderAndCargoManagement.Business.Concrete
{
    public class ArasCargoManager : IArasCargoService
    {
        private IArasCargoRepository _arasCargoRepository;
        private readonly IMapper _mapper;
        public ArasCargoManager(IMapper mapper)
        {
            _arasCargoRepository = new ArasCargoRepository();
            _mapper = mapper;
        }

        public ArasCargoManager()
        {
            _arasCargoRepository = new ArasCargoRepository();

        }

        public async Task<IResult> CanceleOrder(ArasCargoCanceleOrderDto arasCargoCanceleOrderDto,int id)
        {
            var clothingOrder = _mapper.Map<ArasCargo>(arasCargoCanceleOrderDto);
            clothingOrder.OrderCanceledDate = DateTime.Now;
            await _arasCargoRepository.CanceleOrder(id);
            return new Result(ResultStatus.Pending);
        }
        //kodun bu kısmında hata alıyorum. Mapper null dönüyor calısmıyor.
        public async Task<IResult> CreateOrder(ArasCargoAddOrderDto arasCargoAddOrderDto)
        {
            var clothingOrder = _mapper.Map<ArasCargo>(arasCargoAddOrderDto);
            clothingOrder.OrderCreatedDate = DateTime.Now;
            await _arasCargoRepository.CreateOrder(clothingOrder);
            return new Result(ResultStatus.Accepted);
        }

        public async Task<List<ArasCargo>> GetAllOrders()
        {
            return await _arasCargoRepository.GetAllOrders();
        }

        public async Task<ArasCargo> GetOrderById(int id)
        {
            if (id > 0)
            {
                return await _arasCargoRepository.GetOrderById(id);

            }
            throw new Exception("Id cannot be less than 1");
        }

        public async Task<ArasCargo> GetOrderByName(string name)
        {
            if (name != null)
            {
                return await _arasCargoRepository.GetOrderByName(name);

            }
            throw new ArgumentException("Order name was not found");
        }
    }
}
