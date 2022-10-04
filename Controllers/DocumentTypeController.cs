using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/institution/{institutionId}/documentType")]
    [ApiController]
    public class DocumentTypeController : ControllerBase
    {
        private readonly IDocumentTypeService _documentTypeService;

        public DocumentTypeController(IDocumentTypeService documentTypeService)
        {
            _documentTypeService = documentTypeService;
        }

        [HttpPost]
        public ActionResult Post([FromRoute] int institutionId, [FromBody] CreateDokumentTypeDto dto)
        {
            var newDocumentId = _documentTypeService.Create(institutionId, dto);

            return Created($"api/institution/{institutionId}/documentType/{newDocumentId}", null);
        }
    }
}
