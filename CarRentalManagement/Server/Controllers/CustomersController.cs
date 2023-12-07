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
    public class CustomersController : ControllerBase
    {
        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refractored
        //public MakesController(ApplicationDbContext context)
        public CustomersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        public async Task<ActionResult> GetMakes()
        {
            //Refractored
            //return await _context.Makes.ToListAsync();
            var cust = await _unitOfWork.Customers.GetAll();
            return Ok(cust);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetMake(int id)
        {
            var cust = await _unitOfWork.Customers.Get(q => q.Id == id);
            if (cust == null)
            {
                return NotFound();
            }

            //Refractored
            return Ok(cust);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Customer cust)
        {
            if (id != cust.Id)
            {
                return BadRequest();
            }

            //Refractored
            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Customers.Update(cust);

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
                if (!await MakeExists(id))
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
        public async Task<ActionResult<Make>> PostMake(Customer cust)
        {
            //Refractored
            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Customers.Insert(cust);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMake", new { id = cust.Id }, cust);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            //Refractored
            //var make = await _context.Makes.FindAsync(id);
            var cust = await _unitOfWork.Customers.Get(q => q.Id == id);
            if (cust == null)
            {
                return NotFound();
            }

            //Refractored
            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Customers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refractored
        //private bool MakeExists(int id)
        private async Task<bool> MakeExists(int id)
        {
            //Refractored   
            //return _context.Makes.Any(e => e.Id == id);
            var cust = await _unitOfWork.Customers.Get(q => q.Id == id);
            return cust != null;
        }
    }
}
