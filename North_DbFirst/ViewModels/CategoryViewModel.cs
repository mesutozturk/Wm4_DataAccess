namespace North_DbFirst.ViewModels
{
    public class CategoryViewModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public int ProductCount { get; set; } = 0;
    }
}
