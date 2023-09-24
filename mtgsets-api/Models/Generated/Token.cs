using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mtgsets.Models.Generated;

[Table("tokens")]
[Index("Uuid", Name = "tokens_uuid")]
public partial class Token
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

    [Column("availability")]
    public string? Availability { get; set; }

    [Column("boostertypes")]
    public string? Boostertypes { get; set; }

    [Column("bordercolor")]
    public string? Bordercolor { get; set; }

    [Column("coloridentity")]
    public string? Coloridentity { get; set; }

    [Column("colors")]
    public string? Colors { get; set; }

    [Column("edhrecsaltiness")]
    public double? Edhrecsaltiness { get; set; }

    [Column("facename")]
    public string? Facename { get; set; }

    [Column("finishes")]
    public string? Finishes { get; set; }

    [Column("flavortext")]
    public string? Flavortext { get; set; }

    [Column("frameeffects")]
    public string? Frameeffects { get; set; }

    [Column("frameversion")]
    public string? Frameversion { get; set; }

    [Column("hasfoil")]
    public bool? Hasfoil { get; set; }

    [Column("hasnonfoil")]
    public bool? Hasnonfoil { get; set; }

    [Column("isfullart")]
    public bool? Isfullart { get; set; }

    [Column("isfunny")]
    public bool? Isfunny { get; set; }

    [Column("ispromo")]
    public bool? Ispromo { get; set; }

    [Column("isreprint")]
    public bool? Isreprint { get; set; }

    [Column("istextless")]
    public bool? Istextless { get; set; }

    [Column("keywords")]
    public string? Keywords { get; set; }

    [Column("language")]
    public string? Language { get; set; }

    [Column("layout")]
    public string? Layout { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("number")]
    public string? Number { get; set; }

    [Column("orientation")]
    public string? Orientation { get; set; }

    [Column("originaltext")]
    public string? Originaltext { get; set; }

    [Column("originaltype")]
    public string? Originaltype { get; set; }

    [Column("otherfaceids")]
    public string? Otherfaceids { get; set; }

    [Column("power")]
    public string? Power { get; set; }

    [Column("promotypes")]
    public string? Promotypes { get; set; }

    [Column("relatedcards")]
    public string? Relatedcards { get; set; }

    [Column("reverserelated")]
    public string? Reverserelated { get; set; }

    [Column("securitystamp")]
    public string? Securitystamp { get; set; }

    [Column("setcode")]
    public string? Setcode { get; set; }

    [Column("side")]
    public string? Side { get; set; }

    [Column("signature")]
    public string? Signature { get; set; }

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

    [Column("watermark")]
    public string? Watermark { get; set; }
}
