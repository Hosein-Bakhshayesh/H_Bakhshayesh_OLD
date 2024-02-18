using System;
using System.Collections.Generic;

namespace H_BakhshayeshModels.Models;

public partial class BaseInformation:BaseEntity
{
    public Guid BaseInformationId { get; set; }

    public string Code { get; set; } = null!;

    public string TextField { get; set; } = null!;

    public string? Value { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
