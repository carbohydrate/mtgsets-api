using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mtgsets.Models.Generated;

[Table("settranslations")]
[Index("Uuid", Name = "settranslations_uuid")]
public partial class SetTranslation
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("language")]
    public string? Language { get; set; }

    [Column("translation")]
    public string? Translation { get; set; }

    [Column("uuid")]
    [StringLength(36)]
    public string Uuid { get; set; } = null!;
}
