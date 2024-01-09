using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refractored
        //public MakesController(ApplicationDbContext context)
        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        public async Task<ActionResult> GetBookings()
        {
            //Refractored
            //return await _context.Makes.ToListAsync();
            var bookings = await _unitOfWork.Bookings.GetAll(includes: q=>q.Include(x=>x.Vehicle).Include(x=>x.Customer));
            return Ok(bookings);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetBooking(int id)
        {
            var bookings = await _unitOfWork.Bookings.Get(q => q.Id == id);
            if (bookings == null)
            {
                return NotFound();
            }

            //Refractored
            return Ok(bookings);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking bookings)
        {
            if (id != bookings.Id)
            {
                return BadRequest();
            }

            //Refractored
            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Bookings.Update(bookings);

            try
            {
                //Refractored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refractored
                //if (!MakeExists(id))
                if (!await BookingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking bookings)
        {
            //Refractored
            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Bookings.Insert(bookings);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBooking", new { id = bookings.Id }, bookings);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            //Refractored
            //var make = await _context.Makes.FindAsync(id);
            var bookings = await _unitOfWork.Bookings.Get(q => q.Id == id);
            if (bookings == null)
            {
                return NotFound();
            }

            //Refractored
            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Bookings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refractored
        //private bool MakeExists(int id)
        private async Task<bool> BookingExists(int id)
        {
            //Refractored   
            //return _context.Makes.Any(e => e.Id == id);
            var bookings = await _unitOfWork.Bookings.Get(q => q.Id == id);
            return bookings != null;
        }
    }
}

