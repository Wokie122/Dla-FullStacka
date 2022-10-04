using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CreateDokumentTypeDto
    {
        [Required]
        public string Name { get; set; }
        public int InstitutionId { get; set; }
    }
}
