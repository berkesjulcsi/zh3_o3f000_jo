using System;
using System.Collections.Generic;

namespace zh3_o3f000_jo.Models;

public partial class Dolgozók
{
    public int DolgozóId { get; set; }

    public string? DolgozóNév { get; set; }

    public string? Munkaidő { get; set; }

    public int? ÜzletId { get; set; }

    public virtual ICollection<Ügyintézések> Ügyintézéseks { get; set; } = new List<Ügyintézések>();

    public virtual Üzletek? Üzlet { get; set; }
}
