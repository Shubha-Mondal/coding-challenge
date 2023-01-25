using CodingChallenge.Models;

namespace CodingChallenge.Interfaces
{
    public interface IOfficeRepository
    {
        IQueryable<Office> GetOffice();
        IQueryable<Office> GetOfficeByLocation(double latitude, double longitude, int distance);
    }
}
