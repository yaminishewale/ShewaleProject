using HRMSProject.Models;

namespace HRMSProject.Services
{
    public class Services:IServices
    {
        public IEnumerable<House> GetHouses()
        {
            List<House> house = new List<House>()
        {
            new House(){HouseId = 1, HouseNo =533, Address="Bhopal", City="Bhopal", Description="For rent", Locality="HEG", Status="Available", Rent=3000},
            new House(){HouseId = 2, HouseNo =534, Address="Bhopal", City="Bhopal", Description="For rent", Locality="HEG", Status="Available", Rent=3000},
            new House(){HouseId = 3, HouseNo =535, Address="Bhopal", City="Bhopal", Description="For rent", Locality="HEG", Status="Available", Rent=3000},
            new House(){HouseId = 4, HouseNo =501, Address="Bhopal", City="Bhopal", Description="For rent", Locality="HEG", Status="Available", Rent=3000},
            new House(){HouseId = 5, HouseNo =502, Address="Bhopal", City="Bhopal", Description="For rent", Locality="HEG", Status="Available", Rent=3000},
            new House(){HouseId = 6, HouseNo =503, Address="Bhopal", City="Bhopal", Description="For rent", Locality="HEG", Status="Available", Rent=3000},
        };
            return house;
        }

    }
}
