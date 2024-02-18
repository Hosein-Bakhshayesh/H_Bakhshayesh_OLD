using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H_BakhshayeshModels.Models;

namespace H_BakhshayeshServices.Service
{
    public interface IGenericService<T> where T:BaseEntity
    {
    }
}
