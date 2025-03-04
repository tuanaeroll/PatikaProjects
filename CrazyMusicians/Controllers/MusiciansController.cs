using CrazyMusicians.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusicians.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
            private static List<Musician> _musicians = new List<Musician>
            {
                new Musician { Id = 1, Name = "Ahmet Çalgı", Profession = "Ünlü Çalgı Çalar", FunFeature = "Her zaman yanlış nota çalar, ama çok eğlenceli" },
                new Musician { Id = 2, Name = "Zeynep Melodi", Profession = "Popüler Melodi Yazarı", FunFeature = "Şarkıları yanlış anlaşılır ama çok popüler" },
                new Musician { Id = 3, Name = "Cemil Akor", Profession = "Çılgın Akorist", FunFeature = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli" },
                new Musician { Id = 4, Name = "Fatma Nota", Profession = "Sürpriz Nota Üreticisi", FunFeature = "Nota üretirken sürekli sürprizler hazırlar" },
                new Musician { Id = 5, Name = "Hasan Ritim", Profession = "Ritim Canavarı", FunFeature = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir" },
                new Musician { Id = 6, Name = "Elif Armoni", Profession = "Armoni Ustası", FunFeature = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır" },
                new Musician { Id = 7, Name = "Ali Perde", Profession = "Perde Uygulayıcı", FunFeature = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir" },
                new Musician { Id = 8, Name = "Ayşe Rezonans", Profession = "Rezonans Uzmanı", FunFeature = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır" },
                new Musician { Id = 9, Name = "Murat Ton", Profession = "Tonlama Meraklısı", FunFeature = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç" },
                new Musician { Id = 10, Name = "Selin Akor", Profession = "Akor Sihirbazı", FunFeature = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır" }
            };

            [HttpGet]
            public IActionResult Get()
            {
                var response = _musicians.Select(x => new MusicianListResponse
                {
                    Id = x.Id,
                    Name = x.Name,
                    Profession = x.Profession,
                    FunFeature = x.FunFeature
                }).ToList();

                return Ok(response);
            }


            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var musician = _musicians.FirstOrDefault(x => x.Id == id);

                if (musician == null)
            {
                return NotFound();
            }
                var response = new MusicianListResponse
                {
                    Id = musician.Id,
                    Name = musician.Name,
                    Profession = musician.Profession,
                    FunFeature = musician.FunFeature
                };

                return Ok(response);

            }

            [HttpPost]
            public IActionResult AddMusician(MusicianAddRequest request)
            {
                var newMusician = new Musician
                {
                    Id = _musicians.Max(x => x.Id) + 1,
                    Name = request.Name,
                    Profession = request.Profession,
                    FunFeature = request.FunFeature
                };

                _musicians.Add(newMusician);

                return CreatedAtAction(nameof(Get), new { id = newMusician.Id }, newMusician);

            }

            [HttpPut("{id}")]
            public IActionResult ChangeMusician(int id, MusicianUpdateRequest request)
            {
                var musician = _musicians.FirstOrDefault(x => x.Id == id);

                if (musician == null)
            {
                return NotFound();
            }
            musician.Name = request.Name;
            musician.Profession = request.Profession;
            musician.FunFeature = request.FunFeature;

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult ChangeFunFeature(int id, MusicianUpdateFunFeatureRequest request)
        {
            var musician = _musicians.FirstOrDefault(x => x.Id == id);
            if (musician == null)
            {
                return NotFound();
            }
            musician.FunFeature = request.FunFeature;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var musician = _musicians.FirstOrDefault(x => x.Id == id);

            if (musician == null)
            {
                return NotFound();
            }

            _musicians.Remove(musician);

            return Ok();
        }

        [HttpGet("search")]
        public IActionResult SearchMusicians([FromQuery] string? name, [FromQuery] string? profession)
        {
            var result = _musicians
                .Where(m => (string.IsNullOrEmpty(name) || m.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) &&
                            (string.IsNullOrEmpty(profession) || m.Profession.Contains(profession, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            return result.Any() ? Ok(result) : NotFound("No musicians found.");
        }

    }
}
