using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mtgsets.Models.Generated;

[Table("cardpurchaseurls")]
[Index("Uuid", Name = "cardpurchaseurls_uuid")]
public partial class CardPurchaseUrl
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("cardkingdom")]
    public string? Cardkingdom { get; set; }

    [Column("cardkingdometched")]
    public string? Cardkingdometched { get; set; }

    [Column("cardkingdomfoil")]
    public string? Cardkingdomfoil { get; set; }

    [Column("cardmarket")]
    public string? Cardmarket { get; set; }

    [Column("tcgplayer")]
    public string? Tcgplayer { get; set; }

    [Column("tcgplayeretched")]
    public string? Tcgplayeretched { get; set; }

    [Column("uuid")]
    [StringLength(36)]
    public string Uuid { get; set; } = null!;
}
