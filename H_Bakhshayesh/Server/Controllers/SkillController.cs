using AutoMapper;
using H_Bakhshayesh.Shared.ViewModels.Experience;
using H_Bakhshayesh.Shared.ViewModels.Skill;
using H_BakhshayeshModels.Context;
using H_BakhshayeshModels.Models;
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
            List<Skill> skills = _skillServices.GetAll();
            if(skills == null)
            {
                return NotFound(null);
            }
            List<SkillViewModel> model = _mapper.Map<List<Skill>, List<SkillViewModel>>(skills);
            return Ok(model);
        }
        
        [HttpPost("Update")]
        public IActionResult UpdateSkill(SkillViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound("اطلاعات اشتباه ارسال شده است.");
            }
            var skill = _mapper.Map<SkillViewModel, Skill>(model);
            var res = _skillServices.Update(skill);
            _skillServices.Save();
            return Ok(res);
        }
        
        [HttpPost("Delete")]
        public IActionResult DeleteSkill(SkillViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound("اطلاعات اشتباه ارسال شده است.");
            }
            var skill = _mapper.Map<SkillViewModel, Skill>(model);
            var res = _skillServices.Delete(skill);
            _skillServices.Save();
            return Ok(res);
        }

        [HttpPost("Create")]
        public IActionResult CreateSkill(SkillViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound("اطلاعات اشتباه ارسال شده است.");
            }
            var skill = _mapper.Map<SkillViewModel, Skill>(model);
            var res = _skillServices.Add(skill);
            _skillServices.Save();
            return Ok(res);
        }

        [HttpGet("GetEntity/{id}")]
        public IActionResult GetEntity(Guid id)
        {
            Skill skill = _skillServices.GetEntity(id);
            if (skill == null)
            {
                return NotFound("چیزی یافت نشد.");
            }
            SkillViewModel model = _mapper.Map<Skill, SkillViewModel>(skill);
            return Ok(model);
        }
        
        [HttpGet("GetAllIds")]
        public IActionResult GetAllIds()
        {
            List<Skill> skills = _skillServices.GetAll();
            if (skills == null)
            {
                return NotFound("چیزی یافت نشد.");
            }
            List<Guid> ids = new List<Guid>();
            foreach (Skill skill in skills)
            {
                ids.Add(skill.SkillId);
            }
            return Ok(ids);
        }
    }
}
