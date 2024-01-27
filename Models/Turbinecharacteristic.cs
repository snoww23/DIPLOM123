using System;
using System.Collections.Generic;

namespace DIPLOM123.Models;

public partial class Turbinecharacteristic
{
    public long Id { get; set; }

    public long? OdyId { get; set; }

    public long? RdyId { get; set; }

    public long? RegionId { get; set; }

    public long? CityId { get; set; }

    public long? ParticipantId { get; set; }

    public long? StationId { get; set; }

    public long? GtpCode { get; set; }

    public long? TgNumber { get; set; }

    public long? EgoNumber { get; set; }

    public long? MarkingId { get; set; }

    public long? SchemeId { get; set; }

    public string? Year { get; set; }

    public double? Poweractual { get; set; }

    public double? Pmax { get; set; }

    public double? Pmin { get; set; }

    public string? KaNumber { get; set; }

    public string? Pmax1building { get; set; }

    public string? Pmax2building { get; set; }

    public string? Mark { get; set; }

    public long? FuelId { get; set; }

    public virtual City? City { get; set; }

    public virtual Ego? EgoNumberNavigation { get; set; }

    public virtual Fueltype? Fuel { get; set; }

    public virtual Gtp? GtpCodeNavigation { get; set; }

    public virtual Turbinemarking? Marking { get; set; }

    public virtual Ody? Ody { get; set; }

    public virtual Marketparticipant? Participant { get; set; }

    public virtual Rdy? Rdy { get; set; }

    public virtual Region? Region { get; set; }

    public virtual Connectiondiagram? Scheme { get; set; }

    public virtual Station? Station { get; set; }

    public virtual Turbine? TgNumberNavigation { get; set; }
}
