using HRMSProject.Models;

namespace HRMSProject.Services
{
    public interface IServices
    {
        IEnumerable<House> GetHouses();
    }
}
