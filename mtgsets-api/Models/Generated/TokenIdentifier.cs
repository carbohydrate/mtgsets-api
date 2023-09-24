using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mtgsets.Models.Generated;

[Table("tokenidentifiers")]
[Index("Uuid", Name = "tokenidentifiers_uuid")]
public partial class TokenIdentifier
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("cardkingdometchedid")]
    public string? Cardkingdometchedid { get; set; }

    [Column("cardkingdomfoilid")]
    public string? Cardkingdomfoilid { get; set; }

    [Column("cardkingdomid")]
    public string? Cardkingdomid { get; set; }

    [Column("cardsphereid")]
    public string? Cardsphereid { get; set; }

    [Column("mcmid")]
    public string? Mcmid { get; set; }

    [Column("mcmmetaid")]
    public string? Mcmmetaid { get; set; }

    [Column("mtgarenaid")]
    public string? Mtgarenaid { get; set; }

    [Column("mtgjsonfoilversionid")]
    public string? Mtgjsonfoilversionid { get; set; }

    [Column("mtgjsonnonfoilversionid")]
    public string? Mtgjsonnonfoilversionid { get; set; }

    [Column("mtgjsonv4id")]
    public string? Mtgjsonv4id { get; set; }

    [Column("mtgofoilid")]
    public string? Mtgofoilid { get; set; }

    [Column("mtgoid")]
    public string? Mtgoid { get; set; }

    [Column("multiverseid")]
    public string? Multiverseid { get; set; }

    [Column("scryfallid")]
    public string? Scryfallid { get; set; }

    [Column("scryfallillustrationid")]
    public string? Scryfallillustrationid { get; set; }

    [Column("scryfalloracleid")]
    public string? Scryfalloracleid { get; set; }

    [Column("tcgplayeretchedproductid")]
    public string? Tcgplayeretchedproductid { get; set; }

    [Column("tcgplayerproductid")]
    public string? Tcgplayerproductid { get; set; }

    [Column("uuid")]
    [StringLength(36)]
    public string Uuid { get; set; } = null!;
}
