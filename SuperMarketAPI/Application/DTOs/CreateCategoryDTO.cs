namespace SuperMarketAPI.Application.DTOs
{
    public class CreateCategoryDTO
    {
        public string Name { get; set; }

        public CreateCategoryDTO(string name)
        {
            Name = name;

        }
    }
}
