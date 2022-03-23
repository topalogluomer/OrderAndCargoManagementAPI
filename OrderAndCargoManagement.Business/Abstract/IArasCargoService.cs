﻿using OrderAndCargoManagement.Entities;
using OrderAndCargoManagement.Entities.Dtos;
using OrderAndCargoManagement.Entities.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAndCargoManagement.Business.Abstract
{
    public interface IArasCargoService
    {
        Task<List<ArasCargo>> GetAllOrders();
        Task<ArasCargo> GetOrderById(int id);
        Task<ArasCargo> GetOrderByName(string name);
        Task<IResult> CreateOrder(ArasCargoAddOrderDto arasCargoAddOrderDto);
        Task<IResult> CanceleOrder(ArasCargoCanceleOrderDto arasCargoCanceleOrderDto, int id);
    }
}