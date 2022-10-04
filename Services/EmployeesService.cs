using AutoMapper;
using System.Linq;
using WebApplication1.Entities;
using WebApplication1.Exceptions;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IEmployessService
    {
        int Create(int institutionId, CreateEmployeesDto dto);
    }

    public class EmployeesService : IEmployessService
    {
        private readonly InstitutionDbContext _dbContext;
        private readonly IMapper _mapper;

        public EmployeesService(InstitutionDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
           

        public int Create(int institutionId, CreateEmployeesDto dto)
        {
            var institution = _dbContext.Institution.FirstOrDefault(x => x.Id == institutionId);
            if (institution == null)
                throw new NotFoundException("Institution not found");

            var employeesEntity = _mapper.Map<Employees>(dto);

            _dbContext.Employees.Add(employeesEntity);
            _dbContext.SaveChanges();

            employeesEntity.InstitutionId = institutionId;

            return employeesEntity.Id;
        }
    }
}
