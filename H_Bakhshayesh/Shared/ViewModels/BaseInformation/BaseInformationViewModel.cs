using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Bakhshayesh.Shared.ViewModels.BaseInformation
{
    public class BaseInformationViewModel
    {
        [Key]
        [DisplayName("آیدی")]
        public Guid BaseInformationId { get; set; }
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("کد")]
        public string Code { get; set; } = null!;
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("عتوان")]
        public string TextField { get; set; } = null!;
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("مقدار")]
        public string Value { get; set; }
        [DisplayName("تاریخ آخرین آپدیت")]
        public DateTime? UpdatedOn { get; set; }
    }
}
