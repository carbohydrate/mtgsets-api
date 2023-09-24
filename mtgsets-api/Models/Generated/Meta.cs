using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mtgsets.Models.Generated;

[Table("meta")]
public partial class Meta
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("version")]
    public string? Version { get; set; }
}
