using AutoMapper;
using H_Bakhshayesh.Shared.Model;
using H_Bakhshayesh.Shared.ViewModels.Document;
using H_BakhshayeshModels.Context;
using H_BakhshayeshModels.Models;
using H_BakhshayeshServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H_Bakhshayesh.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private IMapper _mapper { get; set; }
        DocumentServices _documentServices;
        HbakhshayeshContext db = new();
        public static string ImageFileName = "1.jpg";

        public DocumentController(IMapper mapper)
        {
            _mapper = mapper;
            _documentServices = new DocumentServices(db);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<Document> documents = _documentServices.GetAll();
            if(documents == null)
            {
                return NotFound(null);
            }
            List<DocumentViewModel> models = _mapper.Map<List<Document>, List<DocumentViewModel>>(documents);
            return Ok(models);
        }

        [HttpPost("Create")]
        public IActionResult CreateDocument(DocumentViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return NotFound("اطلاعات اشتباه ارسال شده است.");
            }
            Document document = _mapper.Map<DocumentViewModel,Document>(model);
            var res = _documentServices.Add(document);
            _documentServices.Save();
            return Ok(res);
        }

        [HttpPost("Update")]
        public IActionResult UpdateDocument(DocumentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound("اطلاعات اشتباه ارسال شده است.");
            }
            Document document = _mapper.Map<DocumentViewModel, Document>(model);
            var res = _documentServices.Update(document);
            _documentServices.Save();
            return Ok(res);
        }

        [HttpPost("Delete")]
        public IActionResult DeleteDocument(DocumentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound("اطلاعات اشتباه ارسال شده است.");
            }
            Document document = _mapper.Map<DocumentViewModel, Document>(model);
            var res = _documentServices.Delete(document);
            _documentServices.Save();
            return Ok(res);
        }
        
        [HttpPut("SaveImage/{fileName}")]
        public async Task<IActionResult> SaveImageDocument([FromBody] ImageFile file, string fileName)
        {
            try
            {
                if (file != null)
                {
                    ImageFileName = fileName;
                    string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()) + "\\Client\\wwwroot\\Images\\Documents\\" + fileName);
                    var buf = Convert.FromBase64String(file.base64data);
                    await System.IO.File.WriteAllBytesAsync(path, buf);
                }
                return Content(ImageFileName);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "انجام نشد");
            }
        }

    }
}
