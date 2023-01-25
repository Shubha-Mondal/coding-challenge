using CodingChallenge.Interfaces;
using CodingChallenge.Models;

namespace CodingChallenge.GraphQL
{
    public class Query
    {
        public IQueryable<Office> GetOffices([Service] IOfficeRepository repo) =>
            repo.GetOffice();

        public IQueryable<Office> OfficesByLocation(double latitude, double longitude, int radiusInKM, [Service] IOfficeRepository repo) =>
           repo.GetOfficeByLocation(latitude, longitude, radiusInKM);
    }
}
