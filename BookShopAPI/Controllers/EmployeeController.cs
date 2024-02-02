using BookShopAPI.DTOs.ManageBooks;
using BookShopAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    public class EmployeeController : ControllerBase, IEmployeeInterface
    {
        public Task AddNewBook(AddBookDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task RemoveBook(RemoveBookDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBook(UpdateBookDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
