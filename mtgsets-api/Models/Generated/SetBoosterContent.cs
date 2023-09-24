using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mtgsets.Models.Generated;

[Table("setboostercontents")]
[Index("Setcode", "Sheetname", "Boostername", "Boosterindex", Name = "setboostercontents_setcode_sheetname_boostername_boosterind_key", IsUnique = true)]
public partial class SetBoosterContent
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("boosterindex")]
    public int? Boosterindex { get; set; }

    [Column("boostername")]
    [StringLength(255)]
    public string? Boostername { get; set; }

    [Column("setcode")]
    [StringLength(20)]
    public string? Setcode { get; set; }

    [Column("sheetname")]
    [StringLength(255)]
    public string? Sheetname { get; set; }

    [Column("sheetpicks")]
    public int? Sheetpicks { get; set; }
}
