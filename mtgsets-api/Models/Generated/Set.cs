using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mtgsets.Models.Generated;

[Table("sets")]
[Index("Code", Name = "sets_code_key", IsUnique = true)]
public partial class Set
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("basesetsize")]
    public int? Basesetsize { get; set; }

    [Column("block")]
    public string? Block { get; set; }

    [Column("cardspheresetid")]
    public int? Cardspheresetid { get; set; }

    [Column("code")]
    [StringLength(8)]
    public string Code { get; set; } = null!;

    [Column("isfoilonly")]
    public bool? Isfoilonly { get; set; }

    [Column("isforeignonly")]
    public bool? Isforeignonly { get; set; }

    [Column("isnonfoilonly")]
    public bool? Isnonfoilonly { get; set; }

    [Column("isonlineonly")]
    public bool? Isonlineonly { get; set; }

    [Column("ispartialpreview")]
    public bool? Ispartialpreview { get; set; }

    [Column("keyrunecode")]
    public string? Keyrunecode { get; set; }

    [Column("languages")]
    public string? Languages { get; set; }

    [Column("mcmid")]
    public int? Mcmid { get; set; }

    [Column("mcmidextras")]
    public int? Mcmidextras { get; set; }

    [Column("mcmname")]
    public string? Mcmname { get; set; }

    [Column("mtgocode")]
    public string? Mtgocode { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("parentcode")]
    public string? Parentcode { get; set; }

    [Column("releasedate")]
    public string? Releasedate { get; set; }

    [Column("tcgplayergroupid")]
    public int? Tcgplayergroupid { get; set; }

    [Column("tokensetcode")]
    public string? Tokensetcode { get; set; }

    [Column("totalsetsize")]
    public int? Totalsetsize { get; set; }

    [Column("type")]
    public string? Type { get; set; }
}
