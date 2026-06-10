using System.ComponentModel.DataAnnotations;

namespace StorageApi.DTOs;

public class CreateProductDto
{
    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string Name { get; set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Price must be zero or greater.")]
    public int Price { get; set; }

    [Required]
    [StringLength(50)]
    public string Category { get; set; }

    [Required]
    [StringLength(20)]
    public string Shelf { get; set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Count must be zero or greater.")]
    public int Count { get; set; }

    [StringLength(500)]
    public string Description { get; set; }
}
