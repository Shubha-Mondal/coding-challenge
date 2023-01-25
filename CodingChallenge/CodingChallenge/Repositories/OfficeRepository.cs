using CodingChallenge.Data;
using CodingChallenge.Helper;
using CodingChallenge.Interfaces;
using CodingChallenge.Models;

namespace CodingChallenge.Repositories
{
    public class OfficeRepository : IOfficeRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public OfficeRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IQueryable<Office> GetOffice()
        {
            return _appDbContext.Offices;
        }
        public IQueryable<Office> GetOfficeByLocation(double latitude, double longitude, int distance)
        {
            var result = _appDbContext.Offices.AsEnumerable().Where(x => x.DistanceBetweenCoordinates(latitude, longitude) < distance);
            return result.AsQueryable();
        }
    }
}
