using AutoMapper;
using H_Bakhshayesh.Shared.ViewModels.Experience;
using H_BakhshayeshModels.Context;
using H_BakhshayeshModels.Models;
using H_BakhshayeshServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace H_Bakhshayesh.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {
        public IMapper _mapper { get; set; }
        public ExperienceServices _experienceServices { get; set; }
        public HbakhshayeshContext db = new HbakhshayeshContext();

        public ExperienceController(IMapper mapper)
        {
            _mapper = mapper;
            _experienceServices = new ExperienceServices(db);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<Experience> experiences = _experienceServices.GetAll();
            if(experiences == null)
            {
                return NotFound("چیزی یافت نشد.");
            }
            List<ExperienceViewModel> list = _mapper.Map<List<Experience>, List<ExperienceViewModel>>(experiences);
            return Ok(list);
        }

        [HttpPost("Create")]
        public IActionResult CreateExperience(ExperienceViewModel model)
        {
            if (model == null)
            {
                return NotFound("اطلاعات اشتباه ارسال شده است.");
            }
            Experience experience = _mapper.Map<ExperienceViewModel, Experience>(model);
            var res = _experienceServices.Add(experience);
            _experienceServices.Save();
            return Ok(res);
        }

        [HttpPost("Update")]
        public IActionResult UpdateExperience(ExperienceViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound("اطلاعات اشتباه ارسال شده است.");
            }
            Experience experience = _mapper.Map<ExperienceViewModel, Experience>(model);
            var res = _experienceServices.Update(experience);
            _experienceServices.Save();
            return Ok(res);
        }

        [HttpPost("Delete")]
        public IActionResult DeleteExperience(ExperienceViewModel model)
        {
            if (model == null)
            {
                return NotFound("اطلاعات اشتباه ارسال شده است.");
            }
            Experience experience = _mapper.Map<ExperienceViewModel, Experience>(model);
            var res = _experienceServices.Delete(experience);
            _experienceServices.Save();
            return Ok(res);
        }
        
        [HttpGet("GetEntity/{id}")]
        public IActionResult GetEntity(Guid id)
        {
            Experience experience = _experienceServices.GetEntity(id);
            if(experience == null)
            {
                return NotFound("چیزی یافت نشد.");
            }
            ExperienceViewModel model = _mapper.Map<Experience,ExperienceViewModel>(experience);
            return Ok(model);
        }

    }
}
