using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CreateCustomersDto
    {
        [Required]
        public string Name { get; set; }
        public string SecoundName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public byte Age { get; set; }
        [Range(11, 11)]
        public string Pesel { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        public string Voicodeship { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string BuldingNumber { get; set; }
        public string ApartmentNumber { get; set; }

        public int InstitutionId { get; set; }
    }
}
