using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UpdateInstitutionDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string OpeningHours { get; set; }
        [EmailAddress]
        public string ContactEmail { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string Voicodeship { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string BuldingNumber { get; set; }
        public string ApartmentNumber { get; set; }
    }
}
