namespace BookShopAPI.DTOs.Books
{
    public class BookCardDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
