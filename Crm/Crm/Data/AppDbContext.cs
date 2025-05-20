using Microsoft.EntityFrameworkCore;

namespace Crm.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Kunde> Kunden { get; set; }
        public DbSet<Termin> Termine { get; set; }
        public DbSet<Rechnung> Rechnungen { get; set; }
    }

    public class Kunde
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Notiz { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telenummer { get; set; } = string.Empty;
        public string Unternehmen { get; set; } = string.Empty;
        public string Branche { get; set; } = string.Empty;

        public int? GesamtUmsatz { get; set; }
        public int? Anzahlverkäufe { get; set; }

        public List<Termin> Termine { get; set; } = new();
        public List<Rechnung> Rechnungen { get; set; } = new();
    }

    public class Termin
    {
        public int TerminId { get; set; }
        public string TerminName { get; set; } = string.Empty;
        public DateTime Datum { get; set; }
        public string Betreff { get; set; } = string.Empty;
        public string? Notiz { get; set; }

        public int KundeId { get; set; }
        public Kunde Kunde { get; set; } = null!;
    }

    public class Rechnung
    {
        public int RechnungId { get; set; }
        public int RechnungNr { get; set; }
        public int RechnungsBetrag { get; set; }

        public DateTime ErstellDatum { get; set; }
        public int KundeId { get; set; }
        public Kunde Kunde { get; set; } = null!;

    }

}

