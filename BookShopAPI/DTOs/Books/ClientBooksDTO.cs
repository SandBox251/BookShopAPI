namespace BookShopAPI.DTOs.Books
{
    public class ClientBooksDTO
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public DateTime PurchesDate { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
    }
}
