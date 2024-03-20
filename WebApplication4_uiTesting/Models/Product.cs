
using System.ComponentModel.DataAnnotations;

namespace UITesting.Models;

public class Product
{
    [Key]
    public Guid ProductID { get; set; }
    [Required]
    [MaxLength(50)]
    public string? ProductName { get; set; }
    public int Price { get; set; }
    public int Qty { get; set; }

}
