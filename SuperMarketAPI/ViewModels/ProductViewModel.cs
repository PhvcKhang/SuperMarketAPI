using SuperMarketAPI.Domain.Models;
    public class ProductViewModel
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public short QuantityInPackage { get; set; }
    public EUnitOfMeasurement unitOfMeasurement { get; set; }
    public int CategoryId { get; set; }
    }
