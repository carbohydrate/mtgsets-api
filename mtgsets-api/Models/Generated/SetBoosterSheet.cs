using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mtgsets.Models.Generated;

[Table("setboostersheets")]
[Index("Setcode", "Sheetname", "Boostername", Name = "setboostersheets_setcode_sheetname_boostername_key", IsUnique = true)]
public partial class SetBoosterSheet
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("boostername")]
    [StringLength(255)]
    public string? Boostername { get; set; }

    [Column("setcode")]
    [StringLength(20)]
    public string? Setcode { get; set; }

    [Column("sheethasbalancecolors")]
    public bool? Sheethasbalancecolors { get; set; }

    [Column("sheetisfoil")]
    public bool? Sheetisfoil { get; set; }

    [Column("sheetname")]
    [StringLength(255)]
    public string? Sheetname { get; set; }
}
