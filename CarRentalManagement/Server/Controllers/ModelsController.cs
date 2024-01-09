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
    public class ModelsController : ControllerBase
    {
        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refractored
        //public MakesController(ApplicationDbContext context)
        public ModelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        public async Task<ActionResult> GetModels()
        {
            //Refractored
            //return await _context.Makes.ToListAsync();
            var model = await _unitOfWork.Models.GetAll();
            return Ok(model);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetModel(int id)
        {
            var model = await _unitOfWork.Models.Get(q => q.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            //Refractored
            return Ok(model);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModel(int id, Model model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            //Refractored
            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Models.Update(model);

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
                if (!await ModelExists(id))
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
        public async Task<ActionResult<Model>> PostModel(Model model)
        {
            //Refractored
            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Models.Insert(model);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMake", new { id = model.Id }, model);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            //Refractored
            //var make = await _context.Makes.FindAsync(id);
            var model = await _unitOfWork.Models.Get(q => q.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            //Refractored
            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Models.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refractored
        //private bool MakeExists(int id)
        private async Task<bool> ModelExists(int id)
        {
            //Refractored   
            //return _context.Makes.Any(e => e.Id == id);
            var model = await _unitOfWork.Models.Get(q => q.Id == id);
            return model != null;
        }
    }
}
