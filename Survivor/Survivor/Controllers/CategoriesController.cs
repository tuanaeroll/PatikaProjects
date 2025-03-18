using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survivor.Context;
using Survivor.Entities;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly SurvivorDbContext _db;

        public CategoriesController(SurvivorDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _db.Categories
                .Where(c => !c.IsDeleted)
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    c.Id,
                    c.Name
                })
                .ToList();

            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var category = _db.Categories.Find(id);
            if (category is null || category.IsDeleted)
            {
                return NotFound();
            }

            return Ok(new
            {
                category.Id,
                category.Name
            });
        }

        [HttpPost]
        public IActionResult AddCategory([FromBody] CategoryEntity category)
        {
            if (category == null || string.IsNullOrWhiteSpace(category.Name))
            {
                return BadRequest("Geçerli bir kategori adı giriniz.");
            }

            _db.Categories.Add(category);
            _db.SaveChanges();

            return CreatedAtAction(nameof(GetCategory), new { id = category.Id }, category);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, [FromBody] CategoryEntity category)
        {
            var existingCategory = _db.Categories.Find(id);
            if (existingCategory is null || existingCategory.IsDeleted)
            {
                return NotFound();
            }

            existingCategory.Name = category.Name;
            existingCategory.ModifiedDate = DateTime.Now;

            _db.Categories.Update(existingCategory);
            _db.SaveChanges();

            return Ok(existingCategory);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = _db.Categories.Find(id);
            if (category is null || category.IsDeleted)
            {
                return NotFound();
            }

            category.IsDeleted = true;
            category.ModifiedDate = DateTime.Now;

            _db.Categories.Update(category);
            _db.SaveChanges();

            return Ok();
        }
    }
}
