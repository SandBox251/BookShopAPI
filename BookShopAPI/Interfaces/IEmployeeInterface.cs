using BookShopAPI.DTOs.ManageBooks;
using BookShopAPI.Models.Entity;

namespace BookShopAPI.Interfaces
{
    interface IEmployeeInterface
    {
        //Book
        Task AddNewBook(AddBookDTO dto);
        Task UpdateBook(UpdateBookDTO dto);
        Task RemoveBook(RemoveBookDTO dto);
    }
}
