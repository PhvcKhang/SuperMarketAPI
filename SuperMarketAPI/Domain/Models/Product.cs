namespace SuperMarketAPI.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement unitOfMeasurement { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Product( string name, short quantityInPackage, EUnitOfMeasurement unitOfMeasurement, int categoryId)
        {
            Name = name;
            QuantityInPackage = quantityInPackage;
            this.unitOfMeasurement = unitOfMeasurement;
            CategoryId = categoryId;
        }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private Product() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
}
