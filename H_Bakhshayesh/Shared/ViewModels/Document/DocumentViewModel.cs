using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Bakhshayesh.Shared.ViewModels.Document
{
    public class DocumentViewModel
    {
        [Key]
        [DisplayName("آیدی")]
        public Guid DocumentId { get; set; }
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("عنوان")]
        public string Title { get; set; } = null!;
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("مسیر فایل")]
        public string FilePath { get; set; } = null!;
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("تاریخ ایجاد")]
        public DateTime CreatedOn { get; set; }
    }
}
