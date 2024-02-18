using H_BakhshayeshModels.Context;
using H_BakhshayeshModels.Models;
using H_BakhshayeshRepository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_BakhshayeshRepository.Repository
{
    public class BaseInformationRepository : GenericRepository<BaseInformation>, IBaseInformationRepository
    {
        public BaseInformationRepository(HbakhshayeshContext context) : base(context)
        {
        }
    }
}
