using AutoMapper;
using H_Bakhshayesh.Shared.ViewModels.Message;
using H_BakhshayeshModels.Context;
using H_BakhshayeshModels.Models;
using H_BakhshayeshServices.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace H_Bakhshayesh.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        public IMapper _mapper { get; set; }
        public MessageServices _messageServices { get; set; }
        public HbakhshayeshContext db = new HbakhshayeshContext();

        public MessageController(IMapper mapper)
        {
            _mapper = mapper;
            _messageServices = new MessageServices(db);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<Message> messages = _messageServices.GetAll();
            if (messages.Count < 0)
            {
                return NotFound("پیغامی یافت نشد.");
            }
            List<MessageViewModel> list = _mapper.Map<List<Message>, List<MessageViewModel>>(messages);
            return Ok(list);
        }

        [HttpPost("Create")]
        public IActionResult CreateMessage(MessageViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound("اطلاعات ارسالی اشتباه است..");
            }
            Message message = _mapper.Map<MessageViewModel, Message>(model);
            var res = _messageServices.Add(message);
            _messageServices.Save();
            return Ok(res);
        }

        [HttpPost("Update")]
        public IActionResult UpdateMessage(MessageViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound("اطلاعات ارسالی اشتباه است..");
            }
            Message message = _mapper.Map<MessageViewModel, Message>(model);
            var res = _messageServices.Update(message);
            _messageServices.Save();
            return Ok(res);
        }

        [HttpPost("Delete")]
        public IActionResult DeleteMessage(MessageViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return NotFound("اطلاعات ارسالی اشتباه است..");
            }
            Message message = _mapper.Map<MessageViewModel, Message>(model);
            var res = _messageServices.Delete(message);
            _messageServices.Save();
            return Ok(res);
        }

    }
}
