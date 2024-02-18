using H_BakhshayeshModels.Context;
using H_BakhshayeshModels.Models;
using H_BakhshayeshServices.Service;

namespace H_BakhshayeshServices.Services
{
    public class DocumentServices : GenericService<Document>,IDocumentServices
    {
        public DocumentServices(HbakhshayeshContext context) : base(context)
        {
        }
    }
}
