using System;
using System.Collections.Generic;

namespace H_BakhshayeshModels.Models;

public partial class Message:BaseEntity
{
    public Guid MessageId { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Text { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
