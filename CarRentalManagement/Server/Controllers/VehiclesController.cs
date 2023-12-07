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
    public class VehiclesController : ControllerBase
    {
        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refractored
        //public MakesController(ApplicationDbContext context)
        public VehiclesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        public async Task<ActionResult> GetMakes()
        {
            //Refractored
            //return await _context.Makes.ToListAsync();
            var veh = await _unitOfWork.Vehicles.GetAll();
            return Ok(veh);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetMake(int id)
        {
            var veh = await _unitOfWork.Vehicles.Get(q => q.Id == id);
            if (veh == null)
            {
                return NotFound();
            }

            //Refractored
            return Ok(veh);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Vehicle veh)
        {
            if (id != veh.Id)
            {
                return BadRequest();
            }

            //Refractored
            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Vehicles.Update(veh);

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
        public async Task<ActionResult<Make>> PostMake(Vehicle veh)
        {
            //Refractored
            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Vehicles.Insert(veh);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVehicle", new { id = veh.Id }, veh);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            //Refractored
            //var make = await _context.Makes.FindAsync(id);
            var veh = await _unitOfWork.Vehicles.Get(q => q.Id == id);
            if (veh == null)
            {
                return NotFound();
            }

            //Refractored
            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Vehicles.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refractored
        //private bool MakeExists(int id)
        private async Task<bool> MakeExists(int id)
        {
            //Refractored   
            //return _context.Makes.Any(e => e.Id == id);
            var veh = await _unitOfWork.Vehicles.Get(q => q.Id == id);
            return veh != null;
        }
    }
}
