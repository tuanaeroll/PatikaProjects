using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survivor.Context;
using Survivor.Entities;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorsController : ControllerBase
    {
        private readonly SurvivorDbContext _db;

        public CompetitorsController(SurvivorDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetCompetitors()
        {
            var competitors = _db.Competitors.Where(x => x.IsDeleted == false).Include(c => c.Category).ToList();
            return Ok(competitors);
        }

        [HttpGet("{id}")]
        public IActionResult GetCompetitor(int id)
        {
            var competitor = _db.Competitors
                .Where(x => !x.IsDeleted).FirstOrDefault(x => x.Id == id);
            if (competitor == null) return NotFound();
            return Ok(competitor);
        }

        [HttpGet("categories/{categoryId}")]
        public IActionResult GetCompetitorsByCategory(int categoryId)
        {
            var competitors = _db.Competitors.Where(x => x.IsDeleted == false)
                .Where(c => c.CategoryId == categoryId)
                .ToList();
            return Ok(competitors);
        }

        [HttpPost]
        public IActionResult CreateCompetitor([FromBody] CompetitorEntity competitor)
        {
            if (competitor == null) return BadRequest();

            _db.Competitors.Add(competitor);
            _db.SaveChanges();

            return CreatedAtAction(nameof(GetCompetitor), new { id = competitor.Id }, competitor);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCompetitor(int id, [FromBody] CompetitorEntity competitor)
        {
            if (id != competitor.Id) return BadRequest();

            var existingCompetitor = _db.Competitors.Find(id);
            if (existingCompetitor == null || existingCompetitor.IsDeleted)
                return NotFound();

            existingCompetitor.FirstName = competitor.FirstName;
            existingCompetitor.LastName = competitor.LastName;
            existingCompetitor.CategoryId = competitor.CategoryId;
            existingCompetitor.ModifiedDate = DateTime.Now;

            _db.Competitors.Update(existingCompetitor);
            _db.SaveChanges();

            return Ok(existingCompetitor);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCompetitor(int id)
        {
            var competitor = _db.Competitors.Find(id);
            if (competitor == null) return NotFound();
            competitor.IsDeleted = true;
            competitor.ModifiedDate = DateTime.Now;

            _db.Competitors.Update(competitor);
            _db.SaveChanges();

            return Ok();
        }

    }
}
