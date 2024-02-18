using System;
using System.Collections.Generic;

namespace H_BakhshayeshModels.Models;

public partial class Skill:BaseEntity
{
    public Guid SkillId { get; set; }

    public string Name { get; set; } = null!;

    public int ProgressValue { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
