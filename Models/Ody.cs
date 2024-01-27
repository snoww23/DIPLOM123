using System;
using System.Collections.Generic;

namespace DIPLOM123.Models;

public partial class Ody
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Turbinecharacteristic> Turbinecharacteristics { get; } = new List<Turbinecharacteristic>();
}
