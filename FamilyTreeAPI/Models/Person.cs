namespace FamilyTreeAPI.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthLocation { get; set; }
        public DateTime? DeathDate { get; set; }
        public string DeathLocation { get; set; }

        public string FullName => $"{GivenName} {Surname}";

        public string Lifespan
        {
            get
            {
                if (DeathDate.HasValue)
                {
                    return BirthDate.HasValue ? $"{BirthDate.Value.Year}-{DeathDate.Value.Year}" : $"-{DeathDate.Value.Year}";
                }

                if (BirthDate.HasValue)
                {
                    int age = DateTime.Now.Year - BirthDate.Value.Year;
                    if (age < 120)
                    {
                        return "Living";
                    }
                    return $"{BirthDate.Value.Year}-";
                }

                return "Living";
            }
        }
    }

}
