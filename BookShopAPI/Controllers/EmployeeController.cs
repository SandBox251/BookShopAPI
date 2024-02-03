using BookShopAPI.Context;
using BookShopAPI.DTOs.ManageBooks;
using BookShopAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    public class EmployeeController : ControllerBase, IEmployeeInterface
    {
        private readonly BookShopDbContext _BookShopDbContext;
        public EmployeeController(BookShopDbContext context)
        {
            _BookShopDbContext = context;
        }

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
