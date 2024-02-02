using static BookShopAPI.Helper.Enums.Enums;

namespace BookShopAPI.DTOs.Person
{
    public class GetPersonDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
