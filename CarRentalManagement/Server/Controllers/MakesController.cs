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
    public class MakesController : ControllerBase
    {
        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refractored
        //public MakesController(ApplicationDbContext context)
        public MakesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        public async Task<ActionResult> GetMakes()
        {
            //Refractored
            //return await _context.Makes.ToListAsync();
            var makes = await _unitOfWork.Makes.GetAll();
            return Ok(makes);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetMake(int id)
        {
            var makes = await _unitOfWork.Makes.Get(q => q.Id == id);
          if (makes == null)
          {
              return NotFound();
          }

            //Refractored
            return Ok(makes);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make makes)
        {
            if (id != makes.Id)
            {
                return BadRequest();
            }

            //Refractored
            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Makes.Update(makes);

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
        public async Task<ActionResult<Make>> PostMake(Make makes)
        {
            //Refractored
            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Makes.Insert(makes);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMake", new { id = makes.Id }, makes);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            //Refractored
            //var make = await _context.Makes.FindAsync(id);
            var makes = await _unitOfWork.Makes.Get(q => q.Id == id);
            if (makes == null)
            {
                return NotFound();
            }

            //Refractored
            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Makes.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refractored
        //private bool MakeExists(int id)
        private async Task<bool> MakeExists(int id)
        {
            //Refractored   
            //return _context.Makes.Any(e => e.Id == id);
            var makes = await _unitOfWork.Makes.Get(q => q.Id == id);
            return makes != null;
        }
    }
}
