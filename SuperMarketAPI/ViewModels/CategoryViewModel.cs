namespace SuperMarketAPI.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductViewModel> products { get; set; }    
    }
}
