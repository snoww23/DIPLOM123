using System;
using System.Collections.Generic;

namespace DIPLOM123.Models;

public partial class Gtp
{
    public long Id { get; set; }

    public string? GtpCode { get; set; }

    public virtual ICollection<Turbinecharacteristic> Turbinecharacteristics { get; } = new List<Turbinecharacteristic>();
}
