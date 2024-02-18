using H_BakhshayeshModels.Context;
using H_BakhshayeshModels.Models;
using H_BakhshayeshServices.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_BakhshayeshServices.Services
{
    public class SkillServices : GenericService<Skill>, ISkillServices
    {
        public SkillServices(HbakhshayeshContext context) : base(context)
        {
        }
    }
}
