using BookShopAPI.DTOs.Authantication;
using BookShopAPI.Models.Entity;
using BookShopAPI.DTOs.Books;
using BookShopAPI.DTOs.Person;

namespace BookShopAPI.Interfaces
{
    interface IAdminInterface
    {

        //Person
        Task<List<GetPersonDTO>> GetPerson(PersonType PersonType, string name);
        Task<GetPersonDetailsDTO> GetPerson(int Id);
        Task CreatePerson (CreatePersonDTO dto);
        Task UpdateProfile (UpdatePersonInfoDTO dto);

    }
}
