namespace BookShopAPI.Models.Entity
{
    public class PersonType
    {
        public int PersonTypeId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Person> Peoples { get; set; }
    }
}
