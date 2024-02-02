﻿using static BookShopAPI.Helper.Enums.Enums;

namespace BookShopAPI.DTOs.ManageBooks
{
    public class AddBookDTO
    {
        public int Id { get; set; }
        public BooksType BookType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
