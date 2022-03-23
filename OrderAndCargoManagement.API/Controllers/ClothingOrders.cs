using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderAndCargoManagement.Business.Abstract;
using OrderAndCargoManagement.Business.Concrete;
using OrderAndCargoManagement.Entities;
using OrderAndCargoManagement.Entities.Dtos;
using OrderAndCargoManagement.Entities.Shared;
using System.Threading.Tasks;

namespace OrderAndCargoManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothingOrders : ControllerBase
    {
        private IArasCargoService _arasCargoService;

        public ClothingOrders()
        {
            _arasCargoService = new ArasCargoManager();

        }

        //giyim siparislerimin hepsini görmek icin
        [HttpGet]
        [Route("[action]")]

        public async Task<IActionResult> GetAllClothingOrders()
        {
            var clothingOrder = await _arasCargoService.GetAllOrders();

            return Ok(clothingOrder);

        }
        [HttpGet]
        [Route("[action]/{id}")]

        public async Task<IActionResult> GetClothingOrderById(int id)
        {
            var clothingOrder = await _arasCargoService.GetOrderById(id);
            if (clothingOrder != null)
            {
                return Ok(clothingOrder);

            }
            return NotFound();
        }

        [HttpGet]
        [Route("[action]/{name}")]
        public async Task<IActionResult> GetClothingOrderByName(string name)
        {
            var clothingOrder = await _arasCargoService.GetOrderByName(name);
            if (clothingOrder != null)
            {
                return Ok(clothingOrder);
            }
            return NotFound();
        }
        [HttpPost]
        [Route("[action]")]

        public async Task<IActionResult> CreateClothingOrder([FromBody] ArasCargoAddOrderDto order)
        {
            var clothingOrder = await _arasCargoService.CreateOrder(order);

            return CreatedAtAction("GetAllClothingOrders", new { clothingOrder });
        }
        //[HttpPut]
        //[Route("[action]/{id}")]

        //public async Task<IActionResult> UpdateClothingOrder([FromBody] ArasCargo order)
        //{
        //    if (await _arasCargoService.GetOrderById(order.Id) != null)
        //    {
        //        return Ok(await _arasCargoService.UpdateOrder(order));
        //    }
        //    return NotFound();
        //}
        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> CanceleClothingOrder(int id, ArasCargoCanceleOrderDto arasCargoCanceleOrderDto)
        {
            if (await _arasCargoService.GetOrderById(id) != null)
            {
                await _arasCargoService.CanceleOrder(arasCargoCanceleOrderDto,id);
                //var a = ResultStatus.Pending;
                //if ()
                //{

                //}
                return Ok();
            }
            return NotFound("Order was not found");
        }
    }
}
