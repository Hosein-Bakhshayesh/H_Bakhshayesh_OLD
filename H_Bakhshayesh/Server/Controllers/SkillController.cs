using AutoMapper;
using H_BakhshayeshModels.Context;
using H_BakhshayeshServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H_Bakhshayesh.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private IMapper _mapper { get; set; }
        SkillServices _skillServices;
        HbakhshayeshContext db = new();

        public SkillController(IMapper mapper)
        {
            _mapper = mapper;
            _skillServices = new SkillServices(db);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
