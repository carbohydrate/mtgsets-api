using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mtgsets.Models.Generated;

[Table("cards")]
[Index("Uuid", Name = "cards_uuid")]
public partial class Card
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("artist")]
    public string? Artist { get; set; }

    [Column("artistids")]
    public string? Artistids { get; set; }

    [Column("asciiname")]
    public string? Asciiname { get; set; }

    [Column("attractionlights")]
    public string? Attractionlights { get; set; }

    [Column("availability")]
    public string? Availability { get; set; }

    [Column("boostertypes")]
    public string? Boostertypes { get; set; }

    [Column("bordercolor")]
    public string? Bordercolor { get; set; }

    [Column("cardparts")]
    public string? Cardparts { get; set; }

    [Column("coloridentity")]
    public string? Coloridentity { get; set; }

    [Column("colorindicator")]
    public string? Colorindicator { get; set; }

    [Column("colors")]
    public string? Colors { get; set; }

    [Column("defense")]
    public string? Defense { get; set; }

    [Column("dueldeck")]
    public string? Dueldeck { get; set; }

    [Column("edhrecrank")]
    public int? Edhrecrank { get; set; }

    [Column("edhrecsaltiness")]
    public double? Edhrecsaltiness { get; set; }

    [Column("faceconvertedmanacost")]
    public double? Faceconvertedmanacost { get; set; }

    [Column("faceflavorname")]
    public string? Faceflavorname { get; set; }

    [Column("facemanavalue")]
    public double? Facemanavalue { get; set; }

    [Column("facename")]
    public string? Facename { get; set; }

    [Column("finishes")]
    public string? Finishes { get; set; }

    [Column("flavorname")]
    public string? Flavorname { get; set; }

    [Column("flavortext")]
    public string? Flavortext { get; set; }

    [Column("frameeffects")]
    public string? Frameeffects { get; set; }

    [Column("frameversion")]
    public string? Frameversion { get; set; }

    [Column("hand")]
    public string? Hand { get; set; }

    [Column("hasalternativedecklimit")]
    public bool? Hasalternativedecklimit { get; set; }

    [Column("hascontentwarning")]
    public bool? Hascontentwarning { get; set; }

    [Column("hasfoil")]
    public bool? Hasfoil { get; set; }

    [Column("hasnonfoil")]
    public bool? Hasnonfoil { get; set; }

    [Column("isalternative")]
    public bool? Isalternative { get; set; }

    [Column("isfullart")]
    public bool? Isfullart { get; set; }

    [Column("isfunny")]
    public bool? Isfunny { get; set; }

    [Column("isonlineonly")]
    public bool? Isonlineonly { get; set; }

    [Column("isoversized")]
    public bool? Isoversized { get; set; }

    [Column("ispromo")]
    public bool? Ispromo { get; set; }

    [Column("isrebalanced")]
    public bool? Isrebalanced { get; set; }

    [Column("isreprint")]
    public bool? Isreprint { get; set; }

    [Column("isreserved")]
    public bool? Isreserved { get; set; }

    [Column("isstarter")]
    public bool? Isstarter { get; set; }

    [Column("isstoryspotlight")]
    public bool? Isstoryspotlight { get; set; }

    [Column("istextless")]
    public bool? Istextless { get; set; }

    [Column("istimeshifted")]
    public bool? Istimeshifted { get; set; }

    [Column("keywords")]
    public string? Keywords { get; set; }

    [Column("language")]
    public string? Language { get; set; }

    [Column("layout")]
    public string? Layout { get; set; }

    [Column("leadershipskills")]
    public string? Leadershipskills { get; set; }

    [Column("life")]
    public string? Life { get; set; }

    [Column("loyalty")]
    public string? Loyalty { get; set; }

    [Column("manacost")]
    public string? Manacost { get; set; }

    [Column("manavalue")]
    public double? Manavalue { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("number")]
    public string? Number { get; set; }

    [Column("originalprintings")]
    public string? Originalprintings { get; set; }

    [Column("originalreleasedate")]
    public string? Originalreleasedate { get; set; }

    [Column("originaltext")]
    public string? Originaltext { get; set; }

    [Column("originaltype")]
    public string? Originaltype { get; set; }

    [Column("otherfaceids")]
    public string? Otherfaceids { get; set; }

    [Column("power")]
    public string? Power { get; set; }

    [Column("printings")]
    public string? Printings { get; set; }

    [Column("promotypes")]
    public string? Promotypes { get; set; }

    [Column("rarity")]
    public string? Rarity { get; set; }

    [Column("rebalancedprintings")]
    public string? Rebalancedprintings { get; set; }

    [Column("relatedcards")]
    public string? Relatedcards { get; set; }

    [Column("securitystamp")]
    public string? Securitystamp { get; set; }

    [Column("setcode")]
    public string? Setcode { get; set; }

    [Column("side")]
    public string? Side { get; set; }

    [Column("signature")]
    public string? Signature { get; set; }

    [Column("sourceproducts")]
    public string? Sourceproducts { get; set; }

    [Column("subsets")]
    public string? Subsets { get; set; }

    [Column("subtypes")]
    public string? Subtypes { get; set; }

    [Column("supertypes")]
    public string? Supertypes { get; set; }

    [Column("text")]
    public string? Text { get; set; }

    [Column("toughness")]
    public string? Toughness { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("types")]
    public string? Types { get; set; }

    [Column("uuid")]
    [StringLength(36)]
    public string Uuid { get; set; } = null!;

    [Column("variations")]
    public string? Variations { get; set; }

    [Column("watermark")]
    public string? Watermark { get; set; }
}
