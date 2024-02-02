using BookShopAPI.DTOs.Authantication;
using BookShopAPI.DTOs.Books;
using static BookShopAPI.Helper.Enums.Enums;

namespace BookShopAPI.Interfaces
{
    interface ISharedInterface
    {        
        //Filltering Book 
        Task<List<BookCardDTO>> GetBooks(string? title, DateTime? time, BooksType? BookType);
        Task<BookDetailsDTO> GetBookDetails(int Id);
        //Create Account
        Task CreateNewAccount(RegistrationDTO dto);
        //Login
        Task Login(LoginDTO dto);
        //ResetPassword
        Task ResetPassword(ResetPasswordDTO dto);
    }
}
