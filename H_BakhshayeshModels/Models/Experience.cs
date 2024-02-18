using System;
using System.Collections.Generic;

namespace H_BakhshayeshModels.Models;

public partial class Experience:BaseEntity
{
    public Guid ExperienceId { get; set; }

    public string Title { get; set; } = null!;

    public string? Icon { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
