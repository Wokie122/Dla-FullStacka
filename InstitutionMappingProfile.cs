
using AutoMapper;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1
{
    public class InstitutionMappingProfile : Profile
    {
        public InstitutionMappingProfile()
        {
            CreateMap<Institution, InstitutionDto>();
            CreateMap<Employees, EmployeesDto>();
            CreateMap<Customers, CustomersDto>();
            CreateMap<DocumentType, DocumentTypeDto>();

            CreateMap<CreateInstitutionDto, Institution>();
            CreateMap<CreateEmployeesDto, Employees>();
            CreateMap<CreateCustomersDto, Customers>();
            CreateMap<CreateDokumentTypeDto, DocumentType>();
        }
    }
}
