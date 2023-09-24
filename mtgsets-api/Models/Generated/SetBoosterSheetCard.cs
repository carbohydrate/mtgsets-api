using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mtgsets.Models.Generated;

[Table("setboostersheetcards")]
[Index("Setcode", "Sheetname", "Boostername", "Carduuid", Name = "setboostersheetcards_setcode_sheetname_boostername_carduuid_key", IsUnique = true)]
public partial class SetBoosterSheetCard
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("boostername")]
    [StringLength(255)]
    public string? Boostername { get; set; }

    [Column("carduuid")]
    [StringLength(36)]
    public string Carduuid { get; set; } = null!;

    [Column("cardweight")]
    public long? Cardweight { get; set; }

    [Column("setcode")]
    [StringLength(20)]
    public string? Setcode { get; set; }

    [Column("sheetname")]
    [StringLength(255)]
    public string? Sheetname { get; set; }
}
