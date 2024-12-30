namespace _07ViewModel.Models
{
    public class ProductViewModel
    {
        public Product? Product { get; set; }
        public string? CategoryName { get; set; }

        public bool isAvailable { get; set; }
        public string Message{ get; set; }
    }
}
