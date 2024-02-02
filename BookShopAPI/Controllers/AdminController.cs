using BookShopAPI.DTOs.Person;
using BookShopAPI.Interfaces;
using BookShopAPI.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BookShopAPI.Controllers
{
    public class AdminController : ControllerBase, IAdminInterface
    {
        public Task CreatePerson(CreatePersonDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<GetPersonDTO>> GetPerson(PersonType PersonType, string name)
        {
            throw new NotImplementedException();
        }

        public Task<GetPersonDetailsDTO> GetPerson(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProfile(UpdatePersonInfoDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
