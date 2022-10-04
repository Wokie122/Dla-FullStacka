using AutoMapper;
using System.Linq;
using WebApplication1.Entities;
using WebApplication1.Exceptions;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IDocumentTypeService
    {
        int Create(int institutionId, CreateDokumentTypeDto dto);
    }

    public class DocumentTypeService : IDocumentTypeService
    {
        private readonly InstitutionDbContext _dbContext;
        private readonly IMapper _mapper;

        public DocumentTypeService(InstitutionDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public int Create(int institutionId, CreateDokumentTypeDto dto)
        {
            var institution = _dbContext.Institution.FirstOrDefault(x => x.Id == institutionId);
            if (institution == null)
                throw new NotFoundException("Institution not found");

            var documentEntity = _mapper.Map<DocumentType>(dto);

            _dbContext.DocumentType.Add(documentEntity);
            _dbContext.SaveChanges();

            documentEntity.InstitutionId = institutionId;

            return documentEntity.Id;
        }
    }
}
