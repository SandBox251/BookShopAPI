using BookShopAPI.DTOs.Books;
using BookShopAPI.DTOs.Person;
using BookShopAPI.Models.Entity;

namespace BookShopAPI.Interfaces
{
    interface IClientInterface
    {
        //Buy Book
        Task BuyBook(BuyBookDTO dto);

        //GetBooksHistoryByUserId
        Task<List<ClientBooksDTO>> GetBooksHistoryByUserId(int Id);

        //Update Profile
        Task UpdateProfile(UpdatePersonInfoDTO dto);

    }
}
