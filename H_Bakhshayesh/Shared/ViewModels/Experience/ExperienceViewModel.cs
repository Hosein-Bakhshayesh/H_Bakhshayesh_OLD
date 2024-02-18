using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Bakhshayesh.Shared.ViewModels.Experience
{
    public class ExperienceViewModel
    {
        [Key]
        [DisplayName("آیدی")]
        public Guid ExperienceId { get; set; }
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("عنوان")]
        public string Title { get; set; } = null!;
        [DisplayName("آیکون")]
        public string? Icon { get; set; }
        [DisplayName("توضیحات")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("تاریخ ایجاد")]
        public DateTime CreatedOn { get; set; }
        [DisplayName("تاریخ آخرین آپدیت")]
        public DateTime? UpdatedOn { get; set; }
    }
}
