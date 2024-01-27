using System;
using System.Collections.Generic;

namespace DIPLOM123.Models;

public partial class Fueltype
{
    public long Id { get; set; }

    public string? Fuel { get; set; }

    public virtual ICollection<Turbinecharacteristic> Turbinecharacteristics { get; } = new List<Turbinecharacteristic>();
}
