using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Bakhshayesh.Shared.ViewModels.Skill
{
    public class SkillViewModel
    {
        [Key]
        [DisplayName("آیدی")]
        public Guid SkillId { get; set; }
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("نام مهارت")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("درصد مهارت")]
        public int ProgressValue { get; set; }
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("تازیخ ایجاد")]
        public DateTime CreatedOn { get; set; }
        [DisplayName("تاریخ آخرین آپدیت")]
        public DateTime? UpdatedOn { get; set; }
    }
}
