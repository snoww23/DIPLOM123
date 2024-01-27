using System;
using System.Collections.Generic;

namespace DIPLOM123.Models;

public partial class Connectiondiagram
{
    public long Id { get; set; }

    public string? Scheme { get; set; }

    public virtual ICollection<Turbinecharacteristic> Turbinecharacteristics { get; } = new List<Turbinecharacteristic>();
}
