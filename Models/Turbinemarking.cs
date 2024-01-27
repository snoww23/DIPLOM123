using System;
using System.Collections.Generic;

namespace DIPLOM123.Models;

public partial class Turbinemarking
{
    public long Id { get; set; }

    public string? Marking { get; set; }

    public virtual ICollection<Turbinecharacteristic> Turbinecharacteristics { get; } = new List<Turbinecharacteristic>();
}
