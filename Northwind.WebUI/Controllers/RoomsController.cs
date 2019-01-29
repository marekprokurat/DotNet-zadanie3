using System.Net;
using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Application.Rooms;
using Northwind.Application.Rooms.Commands;
using Northwind.Application.Rooms.Models;
using Northwind.Application.Rooms.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Collections.Generic;
using Northwind.Domain.Entities;



namespace Northwind.WebUI.Controllers
{
   // public class RoomPreviewModel : DbContext
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoomsController : BaseController
    {
        private readonly Room _context;
        public RoomsController(Room context)
        {
            _context = context;

            if (_context.RoomId == 0)
            {
                // RoomPreviewModel.Add(new RoomPreviewModel );
                // _context.Rooms = new CreateRoomCommand  { RoomId = 1 };
                _context.RoomId = 1; //Int.Parse(new Room );
            }
        }


    // GET: api/products
    [HttpGet]
        public async Task<ActionResult<RoomListModel>> GetAll()
        {
            return Ok(await Mediator.Send(new GetRoomsQuery()));
        }

        // GET: api/products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomDetailsModel>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetRoomDetailsQuery { RoomId = id }));
        }
        
        //calendar
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomDetailsModel>> GetCalendar(int id)
        {
            return Ok(await Mediator.Send(new GetRoomCalendarQuery { RoomId = id }));
        }

        // POST: api/products
        [HttpPost]
        public async Task<ActionResult<RoomPreviewModel>> Create([FromBody] CreateRoomCommand command)
        {

         //   _context.Rooms.Add(room);
        //    await _context.SaveChangesAsync();

          //  return CreatedAtAction("GetRoom", new { id = room.Id }, room);



            var productId = await Mediator.Send(command);

            return Ok(productId);
        }

        // PUT: api/products/5
        [HttpPut("{id}")]
        public async Task<ActionResult<RoomPreviewModel>> Update(
            [FromRoute] int id,
            [FromBody] UpdateRoomCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        // DELETE: api/products/5
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteRoomCommand { RoomId = id });

            return NoContent();
        }
    }
}