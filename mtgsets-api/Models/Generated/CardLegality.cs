using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mtgsets.Models.Generated;

[Table("cardlegalities")]
[Index("Uuid", Name = "cardlegalities_uuid")]
public partial class CardLegality
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("alchemy")]
    public string? Alchemy { get; set; }

    [Column("brawl")]
    public string? Brawl { get; set; }

    [Column("commander")]
    public string? Commander { get; set; }

    [Column("duel")]
    public string? Duel { get; set; }

    [Column("explorer")]
    public string? Explorer { get; set; }

    [Column("future")]
    public string? Future { get; set; }

    [Column("gladiator")]
    public string? Gladiator { get; set; }

    [Column("historic")]
    public string? Historic { get; set; }

    [Column("historicbrawl")]
    public string? Historicbrawl { get; set; }

    [Column("legacy")]
    public string? Legacy { get; set; }

    [Column("modern")]
    public string? Modern { get; set; }

    [Column("oathbreaker")]
    public string? Oathbreaker { get; set; }

    [Column("oldschool")]
    public string? Oldschool { get; set; }

    [Column("pauper")]
    public string? Pauper { get; set; }

    [Column("paupercommander")]
    public string? Paupercommander { get; set; }

    [Column("penny")]
    public string? Penny { get; set; }

    [Column("pioneer")]
    public string? Pioneer { get; set; }

    [Column("predh")]
    public string? Predh { get; set; }

    [Column("premodern")]
    public string? Premodern { get; set; }

    [Column("standard")]
    public string? Standard { get; set; }

    [Column("uuid")]
    [StringLength(36)]
    public string Uuid { get; set; } = null!;

    [Column("vintage")]
    public string? Vintage { get; set; }
}
