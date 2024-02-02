using BookShopAPI.Models.Entity;
using static BookShopAPI.Helper.Enums.Enums;

namespace BookShopAPI.DTOs.Person
{
    public class GetPersonDetailsDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Specialization { get; set; }
        public string Salary { get; set; }
        public bool IsActive { get; set; }
        public virtual PersonType PersonType { get; set; }
    }
}
