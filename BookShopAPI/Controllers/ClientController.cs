using BookShopAPI.DTOs.Books;
using BookShopAPI.DTOs.Person;
using BookShopAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    public class ClientController : ControllerBase, IClientInterface
    {
        public Task BuyBook(BuyBookDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClientBooksDTO>> GetBooksHistoryByUserId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProfile(UpdatePersonInfoDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
