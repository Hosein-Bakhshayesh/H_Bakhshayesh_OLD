using System;
using System.Collections.Generic;

namespace H_BakhshayeshModels.Models;

public partial class Document:BaseEntity
{
    public Guid DocumentId { get; set; }

    public string Title { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
