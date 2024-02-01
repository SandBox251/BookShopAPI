using static BookShopAPI.Helper.Enums.Enums;

namespace BookShopAPI.Models.Entity
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Specialization { get; set; }
        public string Salary { get; set; }
        public bool IsActive { get; set; }


        public virtual PersonType PersonType { get; set; }
    }
}
