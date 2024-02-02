using BookShopAPI.DTOs.Authantication;
using BookShopAPI.DTOs.Books;
using BookShopAPI.Helper.Enums;
using BookShopAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    public class SharedController : ControllerBase, ISharedInterface
    {
        public Task CreateNewAccount(RegistrationDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<BookDetailsDTO> GetBookDetails(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookCardDTO>> GetBooks(string? title, DateTime? time, Enums.BooksType? BookType)
        {
            throw new NotImplementedException();
        }

        public Task Login(LoginDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task ResetPassword(ResetPasswordDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
