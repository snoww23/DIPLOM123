using System;
using System.Collections.Generic;

namespace DIPLOM123.Models;

public partial class Rdy
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Turbinecharacteristic> Turbinecharacteristics { get; } = new List<Turbinecharacteristic>();
}
