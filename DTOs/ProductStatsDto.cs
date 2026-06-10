namespace StorageApi.DTOs;

public class ProductStatsDto
{
    public int TotalProducts { get; set; }
    public long TotalInventoryValue { get; set; }
    public decimal AveragePrice { get; set; }
}
