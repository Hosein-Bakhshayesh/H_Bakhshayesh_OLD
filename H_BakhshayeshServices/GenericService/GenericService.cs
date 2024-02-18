using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H_BakhshayeshModels.Context;
using H_BakhshayeshModels.Models;
using H_BakhshayeshRepository.GenericRepository;

namespace H_BakhshayeshServices.Service
{
    public class GenericService<T> : GenericRepository<T> where T : BaseEntity
    {
        public GenericService(HbakhshayeshContext context) : base(context)
        {
        }
    }
}
