using BookShopAPI.Models.Entity;
using static BookShopAPI.Helper.Enums.Enums;

namespace BookShopAPI.DTOs.Authantication
{
    public class RegistrationDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
    }
}
