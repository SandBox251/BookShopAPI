using BookShopAPI.DTOs.Authantication;
using BookShopAPI.DTOs.Books;
using static BookShopAPI.Helper.Enums.Enums;

namespace BookShopAPI.Interfaces
{
    interface ISharedInterface
    {        
        //Filltering Book 
        Task<List<BookCardDTO>> GetBooks(string? title, string? Author, int? type);
        Task<BookDetailsDTO> GetBookDetails(int Id);
        //Create Account
        Task CreateNewAccount(RegistrationDTO dto);
        //Login
        Task Login(LoginDTO dto);
        //ResetPassword
        Task ResetPassword(ResetPasswordDTO dto);
    }
}
