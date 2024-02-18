using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Bakhshayesh.Shared.ViewModels.Message
{
    public class MessageViewModel
    {
        [Key]
        [Required]
        [DisplayName("آیدی")]
        public Guid MessageId { get; set; }
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("نام و نام خانوادگی")]
        public string FullName { get; set; } = null!;
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("ایمیل")]
        [DataType(DataType.EmailAddress,ErrorMessage = "فیلد {0} بصورت درست وارد نشده است")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("متن پیام")]
        public string Text { get; set; } = null!;
        [Required(ErrorMessage = "فیلد {0} ضروری است")]
        [DisplayName("تاریخ ایجاد")]
        public DateTime CreatedOn { get; set; }
    }
}
