using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mtgsets.Models.Generated;

[Table("cardforeigndata")]
[Index("Uuid", Name = "cardforeigndata_uuid")]
public partial class CardForeignData
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("facename")]
    public string? Facename { get; set; }

    [Column("flavortext")]
    public string? Flavortext { get; set; }

    [Column("language")]
    public string? Language { get; set; }

    [Column("multiverseid")]
    public int? Multiverseid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("text")]
    public string? Text { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("uuid")]
    [StringLength(36)]
    public string Uuid { get; set; } = null!;
}
