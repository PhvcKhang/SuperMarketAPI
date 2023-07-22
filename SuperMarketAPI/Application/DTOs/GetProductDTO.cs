
namespace SuperMarketAPI.Application.DTOs
{
    public class GetProductDTO
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public GetProductDTO(int categoryId, int productId)
        {
            CategoryId = categoryId;
            ProductId = productId;
        }
    }
}
