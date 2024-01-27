using System;
using System.Collections.Generic;

namespace DIPLOM123.Models;

public partial class Ego
{
    public long Id { get; set; }

    public string? EgoNumber { get; set; }

    public virtual ICollection<Turbinecharacteristic> Turbinecharacteristics { get; } = new List<Turbinecharacteristic>();
}
