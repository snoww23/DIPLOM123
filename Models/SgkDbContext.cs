using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DIPLOM123.Models;

public partial class SgkDbContext : DbContext
{
    public SgkDbContext()
    {
    }

    public SgkDbContext(DbContextOptions<SgkDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Connectiondiagram> Connectiondiagrams { get; set; }

    public virtual DbSet<Ego> Egos { get; set; }

    public virtual DbSet<Fueltype> Fueltypes { get; set; }

    public virtual DbSet<Gtp> Gtps { get; set; }

    public virtual DbSet<Marketparticipant> Marketparticipants { get; set; }

    public virtual DbSet<Ody> Odies { get; set; }

    public virtual DbSet<Rdy> Rdies { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Station> Stations { get; set; }

    public virtual DbSet<Turbine> Turbines { get; set; }

    public virtual DbSet<Turbinecharacteristic> Turbinecharacteristics { get; set; }

    public virtual DbSet<Turbinemarking> Turbinemarkings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=sgk_db;Username=postgres;Password=202861");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Cities_pkey");

            entity.ToTable("cities");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Connectiondiagram>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ConnectionDiagrams_pkey");

            entity.ToTable("connectiondiagrams");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Scheme).HasColumnName("scheme");
        });

        modelBuilder.Entity<Ego>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("EGO_pkey");

            entity.ToTable("ego");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.EgoNumber).HasColumnName("ego_number");
        });

        modelBuilder.Entity<Fueltype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("FuelTypes_pkey");

            entity.ToTable("fueltypes");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Fuel).HasColumnName("fuel");
        });

        modelBuilder.Entity<Gtp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("GTP_pkey");

            entity.ToTable("gtp");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.GtpCode).HasColumnName("gtp_code");
        });

        modelBuilder.Entity<Marketparticipant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Market participants_pkey");

            entity.ToTable("marketparticipants");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Ody>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ODY_pkey");

            entity.ToTable("ody");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Rdy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("rdy2_pkey");

            entity.ToTable("rdy");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Regions_pkey");

            entity.ToTable("regions");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Station>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Stations_pkey");

            entity.ToTable("stations");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Turbine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Turbines_pkey");

            entity.ToTable("turbines");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.TgNumber).HasColumnName("tg_number");
        });

        modelBuilder.Entity<Turbinecharacteristic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("turbinecharacteristics_pkey");

            entity.ToTable("turbinecharacteristics");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.EgoNumber).HasColumnName("ego_number");
            entity.Property(e => e.FuelId).HasColumnName("fuel_id");
            entity.Property(e => e.GtpCode).HasColumnName("gtp_code");
            entity.Property(e => e.KaNumber).HasColumnName("ka_number");
            entity.Property(e => e.Mark).HasColumnName("mark");
            entity.Property(e => e.MarkingId).HasColumnName("marking_id");
            entity.Property(e => e.OdyId).HasColumnName("ody_id");
            entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
            entity.Property(e => e.Pmax).HasColumnName("pmax");
            entity.Property(e => e.Pmax1building).HasColumnName("pmax1building");
            entity.Property(e => e.Pmax2building).HasColumnName("pmax2building");
            entity.Property(e => e.Pmin).HasColumnName("pmin");
            entity.Property(e => e.Poweractual).HasColumnName("poweractual");
            entity.Property(e => e.RdyId).HasColumnName("rdy_id");
            entity.Property(e => e.RegionId).HasColumnName("region_id");
            entity.Property(e => e.SchemeId).HasColumnName("scheme_id");
            entity.Property(e => e.StationId).HasColumnName("station_id");
            entity.Property(e => e.TgNumber).HasColumnName("tg_number");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.City).WithMany(p => p.Turbinecharacteristics)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("city_fkey");

            entity.HasOne(d => d.EgoNumberNavigation).WithMany(p => p.Turbinecharacteristics)
                .HasForeignKey(d => d.EgoNumber)
                .HasConstraintName("ego_fkey");

            entity.HasOne(d => d.Fuel).WithMany(p => p.Turbinecharacteristics)
                .HasForeignKey(d => d.FuelId)
                .HasConstraintName("fuel_fkey");

            entity.HasOne(d => d.GtpCodeNavigation).WithMany(p => p.Turbinecharacteristics)
                .HasForeignKey(d => d.GtpCode)
                .HasConstraintName("gtp_fkey");

            entity.HasOne(d => d.Marking).WithMany(p => p.Turbinecharacteristics)
                .HasForeignKey(d => d.MarkingId)
                .HasConstraintName("marking_fkey");

            entity.HasOne(d => d.Ody).WithMany(p => p.Turbinecharacteristics)
                .HasForeignKey(d => d.OdyId)
                .HasConstraintName("ody_fkey");

            entity.HasOne(d => d.Participant).WithMany(p => p.Turbinecharacteristics)
                .HasForeignKey(d => d.ParticipantId)
                .HasConstraintName("participant_fkey");

            entity.HasOne(d => d.Rdy).WithMany(p => p.Turbinecharacteristics)
                .HasForeignKey(d => d.RdyId)
                .HasConstraintName("rdy_fkey");

            entity.HasOne(d => d.Region).WithMany(p => p.Turbinecharacteristics)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("region_fkey");

            entity.HasOne(d => d.Scheme).WithMany(p => p.Turbinecharacteristics)
                .HasForeignKey(d => d.SchemeId)
                .HasConstraintName("scheme_fkey");

            entity.HasOne(d => d.Station).WithMany(p => p.Turbinecharacteristics)
                .HasForeignKey(d => d.StationId)
                .HasConstraintName("station_fkey");

            entity.HasOne(d => d.TgNumberNavigation).WithMany(p => p.Turbinecharacteristics)
                .HasForeignKey(d => d.TgNumber)
                .HasConstraintName("tg_fkey");
        });

        modelBuilder.Entity<Turbinemarking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TurbineMarkings_pkey");

            entity.ToTable("turbinemarkings");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Marking).HasColumnName("marking");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
