using Microsoft.AspNetCore.Mvc;
using Ocr_backend.Entities;

namespace Ocr_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class documentsController : ControllerBase
    {
        public documentsController()
        {
            
        }

        [HttpPost]
        [Route("certificate")]
        public async Task<IActionResult> certificate(IFormFile file)
        {
            
            Certificate certificate = new Certificate
            {
                Institution = "Technische Hochschule Brandenburg",
                Student = new Student
                {
                    Name = "Max",
                    LastName = "Newmann"
                },
                Valuation = new List<Subject>
                {
                    new Subject(){Course = "Deutsch", Note = "sehr gut"},
                    new Subject(){Course = "Mathematik", Note = "gut"},
                    new Subject(){Course = "Englisch", Note = "befriedigend"},
                    new Subject(){Course = "Physik", Note = "gut"},
                    new Subject(){Course = "Biologie", Note = "sehr gut"},
                    new Subject(){Course = "Chemie", Note = "sehr gut"},
                    new Subject(){Course = "Geschichte", Note = "sehr gut"},
                    new Subject(){Course = "Musik", Note = "gut"},
                    new Subject(){Course = "Geografie", Note = "sehr gut"},
                    new Subject(){Course = "Sport", Note = "sehr gut"},
                    new Subject(){Course = "Ethik", Note = "befriedigend"},
                    new Subject(){Course = "Kunst", Note = "gut"}
                },
                Title = "Abschlusszeugnis"
                
            };
            if(file != null)
            {
              return Ok(certificate);
            }
            return BadRequest("Ivyko nesamone");
        }
    }
}
