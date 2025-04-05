using FamilyTreeAPI.Models;

namespace FamilyTreeAPI.Services
{
    public static class FamilyTreeService
    {
        public static List<FamilyTree> GetFamilyTrees()
        {
            return new List<FamilyTree>
        {
            new FamilyTree
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                People = new List<Person>
                {
                    new Person
                    {
                        Id = Guid.NewGuid(),
                        GivenName = "Rahul",
                        Surname = "Patel",
                        Gender = Gender.Male,
                        BirthDate = new DateTime(1980, 5, 12),
                        DeathDate = new DateTime(2020, 3, 5),
                        BirthLocation = "India",
                        DeathLocation = "Los Angeles"
                    },
                    new Person
                    {
                        Id = Guid.NewGuid(),
                        GivenName = "Mauli",
                        Surname = "Patil",
                        Gender = Gender.Female,
                        BirthDate = new DateTime(1915, 8, 25),
                        DeathDate = new DateTime(2000, 11, 10),
                        BirthLocation = "Miami",
                        DeathLocation = "Paris"
                    },
                    new Person
                    {
                        Id = Guid.NewGuid(),
                        GivenName = "Ram",
                        Surname = "Gonda",
                        Gender = Gender.Male,
                        BirthDate = new DateTime(1955, 2, 20),
                        BirthLocation = "Mumbai",
                        DeathLocation = null
                    }
                }
            },
            new FamilyTree
            {
                Id = new Guid("00000000-0000-0000-0000-000000000002"),
                People = new List<Person>
                {
                    new Person
                    {
                        Id = Guid.NewGuid(),
                        GivenName = "Emma",
                        Surname = "Jones",
                        Gender = Gender.Female,
                        BirthDate = new DateTime(2005, 7, 16),
                        BirthLocation = "Miami",
                        DeathLocation = null
                    }
                }
            }
        };
        }
    }

}
