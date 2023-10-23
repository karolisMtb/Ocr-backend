using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Ocr_backend.Entities
{
    public class Certificate
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public List<Subject> Valuation { get; set; }
        public string Institution { get; set; }
        public Student Student { get; set; }
        public string Title { get; set; }
        public DateTime IssuedDate { get; set; } = DateTime.UtcNow;
    }
}
