using System.Collections.Generic;
using System.Linq;
using WebApplication1.Entities;

namespace WebApplication1
{
    public class InstitutionSeeder
    {
        private readonly InstitutionDbContext _dbContext;

        public InstitutionSeeder(InstitutionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Institution.Any())
                {
                    var institutions = GetInstitution();
                    _dbContext.Institution.AddRange(institutions);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Institution> GetInstitution()
        {
            var institutions = new List<Institution>()
            {
                new Institution()
                {
                    Name = "Urzad Miejski w Bielsku-Białej",
                    Description = "Urząd Miejski",
                    Category = "Urzad Miejski",
                    OpeningHours = "9:00 - 17:00",
                    ContactEmail = "UrzadBielsko@urzad.pl",
                    Voicodeship = "Śląskie",
                    City = "Bielsko-Biała",
                    Street = "Plac Ratuszowy",
                    PostalCode = "43-300",
                    BuldingNumber = "1",
                    Employees = new List<Employees>()
                    {
                        new Employees()
                        {
                            Postion = "Prezes",
                            Name = "Andrzej",
                            SecoundName = "Krzysztof",
                            LastName = "Kryszałowicz",
                            PhoneNumber = "+48888452859",
                            Age = 36,
                            Pesel = "94025069401",
                            PostalCode = "43-300",
                            Voicodeship = "Śląskie",
                            City = "Bielsko-Biała",
                            Street = "Muchomorów",
                            BuldingNumber = "3a",
                            ApartmentNumber = "2"
                        },
                        new Employees()
                        {
                            Postion = "Księgowa",
                            Name = "Dorota",
                            LastName = "Nowak",
                            Age = 61,
                            PhoneNumber = "+48957481934",
                            Pesel = "86949785961",
                            PostalCode = "45-606",
                            Voicodeship = "Śląskie",
                            City = "Kozy",
                            Street = "Bielska",
                            BuldingNumber = "27"
                        },
                    },
                    Customers = new List<Customers>()
                    {
                        new Customers()
                        {
                            Name = "Danuta",
                            SecoundName = "Urszula",
                            LastName = "Kozłowska",
                            Age = 45,
                            Pesel = "9965069401",
                            PostalCode = "43-300",
                            PhoneNumber = "+48835461753",
                            Voicodeship = "Śląskie",
                            City = "Bielsko-Biała",
                            Street = "Szwolerzerów",
                            BuldingNumber = "37",
                            ApartmentNumber = "1"
                        },
                        new Customers()
                        {
                            Name = "Krystian",
                            SecoundName = "Paweł",
                            LastName = "Piotrowicz",
                            Age = 35,
                            Pesel = "9968489401",
                            PhoneNumber = "+48947582143",
                            PostalCode = "43-300",
                            Voicodeship = "Śląskie",
                            City = "Bielsko-Biała",
                            Street = "Reja",
                            BuldingNumber = "12",
                            ApartmentNumber = "11"
                        },
                    },
                    DocumentType = new List<DocumentType>
                    {
                        new DocumentType()
                        {
                            Name = "Prawo Jazdy"
                        },
                        new DocumentType()
                        {
                            Name = "Dowód Osobisty"
                        }

                    }

                }
            };
            return institutions;
        }
    }
}
