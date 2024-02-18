using AutoMapper;
using H_BakhshayeshModels.Context;
using H_BakhshayeshServices.Services;
using H_BakhshayeshModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using H_Bakhshayesh.Shared.ViewModels.BaseInformation;
using System.Net;

namespace H_Bakhshayesh.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseInformationController : ControllerBase
    {
        private IMapper _mapper { get; set; }
        BaseInformationServices _baseInformationServices;
        HbakhshayeshContext db = new();

        public BaseInformationController(IMapper mapper)
        {
            _mapper = mapper;
            _baseInformationServices = new BaseInformationServices(db);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<BaseInformation> baseInformations = _baseInformationServices.GetAll();
            if(baseInformations == null)
            {
                return NotFound("اطلاعاتی یافت نشد.");
            }
            List<BaseInformationViewModel> list = _mapper.Map<List<BaseInformation>, List<BaseInformationViewModel>>(baseInformations);
            return Ok(list);
        }

        [HttpGet("GetBaseInformation/{id}")]
        public IActionResult GetBaseInformation(Guid id)
        {
            BaseInformation baseInformation = _baseInformationServices.GetEntity(id);
            if (baseInformation == null)
            {
                return NotFound("اطلاعاتی یافت نشد.");
            }
            BaseInformationViewModel model = _mapper.Map<BaseInformation, BaseInformationViewModel>(baseInformation);
            return Ok(model);
        }

        [HttpPost("Update")]
        public IActionResult GetBaseInformation(BaseInformationViewModel editModel)
        {
            BaseInformation baseInformation = _mapper.Map<BaseInformationViewModel,BaseInformation>(editModel);
            var res = _baseInformationServices.Update(baseInformation);
            if(res == true)
            {
                _baseInformationServices.Save();
                return Ok(res);
            }
            else
            {
                return Ok(res);
            }
        }
    }
}
