using AutoMapper;
using System.Linq;
using WebApplication1.Entities;
using WebApplication1.Exceptions;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface ICustomerService
    {
        int Create(int institutionId, CreateCustomersDto dto);
    }


    public class CustomerService : ICustomerService
    {
        private readonly InstitutionDbContext _dbContext;
        private readonly IMapper _mapper;

        public CustomerService(InstitutionDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public int Create(int institutionId, CreateCustomersDto dto)
        {
            var institution = _dbContext.Institution.FirstOrDefault(x => x.Id == institutionId);
            if (institution is null)
                throw new NotFoundException("Not Found");

            var institutionEntity = _mapper.Map<Customers>(dto);

            institutionEntity.InstitutionId = institutionId;

            _dbContext.Customers.Add(institutionEntity);
            _dbContext.SaveChanges();

            return institutionEntity.Id;
        }
    }
}
