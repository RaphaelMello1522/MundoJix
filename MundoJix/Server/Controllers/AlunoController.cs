using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MundoJix.Server.Data;
using MundoJix.Shared.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MundoJix.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public AlunoController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<Aluno>>> Get()
        {
            return await _db.Aluno.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<Aluno>> GetById(int id)
        {
            return await _db.Aluno.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Aluno aluno)
        {
            _db.Entry(aluno).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}", Name = "GetByIdAplicacao")]
        public async Task<ActionResult<Aluno>> GetByIdAluno(int id)
        {
            _db.Entry(id).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();

            return await _db.Aluno.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Aluno aluno)
        {
            _db.Add(aluno);
            await _db.SaveChangesAsync();
            return new CreatedAtRouteResult(nameof(GetById), new { aluno.Id }, aluno);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var aluno = await _db.Aluno.FirstOrDefaultAsync(x => x.Id == id);
            _db.Remove(aluno);
            await _db.SaveChangesAsync();

            return NoContent();
        }

    }
}
