namespace StorageApi.DTOs;

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public int Count { get; set; }
    public decimal InventoryValue => Price * Count;
}
