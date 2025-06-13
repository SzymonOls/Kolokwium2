using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium.Models;

[Table("Responsible")]
[PrimaryKey(nameof(BatchId), nameof(Employee))]
public class Responsible
{
    [ForeignKey(nameof(SeedlingBatch))]
    public int BatchId { get; set; }
    [ForeignKey(nameof(Employee1))]
    public int Employee { get; set; }
    [MaxLength(100)]
    public string Role { get; set; }
    
    public SeedlingBatch SeedlingBatch { get; set; }
    public Employee Employee1 { get; set; }
}