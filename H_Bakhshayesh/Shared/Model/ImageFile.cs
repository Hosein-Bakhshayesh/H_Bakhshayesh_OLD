using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Bakhshayesh.Shared.Model
{
    public class ImageFile
    {
        public string base64data { get; set; } = null!;
        public string contentType { get; set; } = null!;
        public string fileName { get; set; } = null!;
    }

}
