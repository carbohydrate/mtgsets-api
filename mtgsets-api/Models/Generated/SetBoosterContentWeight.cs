using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mtgsets.Models.Generated;

[Table("setboostercontentweights")]
public partial class SetBoosterContentWeight
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("boosterindex")]
    public int? Boosterindex { get; set; }

    [Column("boostername")]
    [StringLength(255)]
    public string? Boostername { get; set; }

    [Column("boosterweight")]
    public int? Boosterweight { get; set; }

    [Column("setcode")]
    [StringLength(20)]
    public string? Setcode { get; set; }
}
