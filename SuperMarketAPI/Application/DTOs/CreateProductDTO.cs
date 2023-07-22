using SuperMarketAPI.Domain.Models;

namespace SuperMarketAPI.Application.DTOs
{
    public class CreateProductDTO
    {
        public string Name { get; set; }    
        public int CategoryId { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement unitOfMeasurement { get; set; }

        public CreateProductDTO( string name, int categoryId, short quantityInPackage, EUnitOfMeasurement unitOfMeasurement)
        {
            Name = name;
            CategoryId = categoryId;
            QuantityInPackage = quantityInPackage;
            this.unitOfMeasurement = unitOfMeasurement;
        }
    }
}
