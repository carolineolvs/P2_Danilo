using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DisciplinasApi.Data;
using DisciplinasApi.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DisciplinasApi.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class DisciplinasController : ControllerBase
	{
		private readonly AppDbContext _context;

		public DisciplinasController(AppDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<IEnumerable<Disciplina>> GetAll()
		{
			return await _context.Disciplinas.ToListAsync();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Disciplina>> GetById(int id)
		{
			var disciplina = await _context.Disciplinas.FindAsync(id);

			if (disciplina == null)
				return NotFound();

			return disciplina;
		}

		[HttpPost]
		public async Task<ActionResult<Disciplina>> Create(Disciplina disciplina)
		{
			_context.Disciplinas.Add(disciplina);
			await _context.SaveChangesAsync();

			return CreatedAtAction(nameof(GetById), new { id = disciplina.Id }, disciplina);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Update(int id, Disciplina disciplina)
		{
			if (id != disciplina.Id)
				return BadRequest();

			_context.Entry(disciplina).State = EntityState.Modified;
			await _context.SaveChangesAsync();

			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			var disciplina = await _context.Disciplinas.FindAsync(id);

			if (disciplina == null)
				return NotFound();

			_context.Disciplinas.Remove(disciplina);
			await _context.SaveChangesAsync();

			return NoContent();
		}
	}
}
