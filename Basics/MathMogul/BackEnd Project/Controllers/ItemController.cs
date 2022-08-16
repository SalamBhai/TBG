using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackEnd_Project.Interfaces;
using BackEnd_Project.DTOs;
namespace BackEnd_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
         private readonly IItemService _itemService;
         public ItemController(IItemService itemServ)
         {
            _itemService= itemServ;
         }
          [HttpPost("CreateItem")]
         public IActionResult Create([FromBody] CreateItem body)
         {
           return Ok( _itemService.Create(body));
         }
           [HttpGet("{id}")]
         public IActionResult Get([FromRoute] int id)
         {
           return Ok(_itemService.GetItem(id));
         }
         [HttpGet("GetAll")]
         public IActionResult GetAll()
         {
            ItemGrossPriceDTO dto =  new ItemGrossPriceDTO()
            {
                Items =  _itemService.GetItems(),
                GrossTotalPrice = _itemService.GrossTotalPriceOfItem(),
            };
            return Ok(dto);
         }
           [HttpPut("UpdateItem/{id}")]
         public IActionResult Update([FromRoute] int id, [FromBody] ItemUpdateRequestModel model)
         {
           return Ok(_itemService.Update(model,id));
         }
            [HttpDelete("{id}")]
          public IActionResult Delete([FromRoute]int id)
          {
            var itemToDelete =  _itemService.Delete(id);
            return Ok(itemToDelete);
          }
    }
}