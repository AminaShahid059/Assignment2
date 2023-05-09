using EveryHourEatsProject.Data;
using EveryHourEatsProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EveryHourEatsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly AppDbcontext _appDbContext;
        public OrderController(AppDbcontext appDbcontext){

            _appDbContext = appDbcontext;

           }
        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetOrder()
        {
            var order = await _appDbContext.Order.ToListAsync();
            return Ok(order);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, [FromBody] Order updatedOrder)
        {
            // Check if the order exists
            var order = await _appDbContext.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            // Update the order properties with the new values
            order.id = updatedOrder.id;
            order.name = updatedOrder.name;
            order.phone = updatedOrder.phone;
            order.order = updatedOrder.order;
            order.additional = updatedOrder.additional;
            order.address = updatedOrder.address;
            

            // add more properties here as needed

            // Save the changes to the database
            await _appDbContext.SaveChangesAsync();

            // Return a success response
            return Ok(order);
        }

    }
}
