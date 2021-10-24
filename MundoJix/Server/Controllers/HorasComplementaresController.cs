using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MundoJix.Server.Data;
using MundoJix.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MundoJix.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HoraController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public HoraController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<HorasComplementares>>> Get()
        {
            return await _db.HorasComplementares.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetById1")]
        public async Task<ActionResult<HorasComplementares>> GetById(int id)
        {
            return await _db.HorasComplementares.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(HorasComplementares horasComplementares)
        {
            _db.Entry(horasComplementares).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Post(HorasComplementares horasComplementares)
        {
            _db.Add(horasComplementares);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetById), new { horasComplementares.Id }, horasComplementares);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var horasComplementares = await _db.HorasComplementares.FirstOrDefaultAsync(x => x.Id == id);
            _db.Remove(horasComplementares);
            await _db.SaveChangesAsync();

            return NoContent();
        }

    }
}

