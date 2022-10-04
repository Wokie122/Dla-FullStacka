using System.Collections.Generic;

namespace WebApplication1.Entities
{
    public class Institution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string OpeningHours { get; set; }
        public string ContactEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string Voicodeship { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string BuldingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public virtual List<Employees> Employees { get; set; }
        public virtual List<Customers> Customers { get; set; }
        public virtual List<DocumentType> DocumentType { get; set; }
    }
}
