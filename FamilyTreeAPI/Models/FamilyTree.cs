namespace FamilyTreeAPI.Models
{
    public class FamilyTree
    {
        public Guid Id { get; set; }
        public List<Person> People { get; set; }
    }

}
