using CodingChallenge.Models;

namespace CodingChallenge.Helper
{
    public static class Utilities
    {
        public static double DistanceBetweenCoordinates(this Office office, double fromLatitude, double fromLongitude)
        {
            double x = 69.1 * (office.Latitude - fromLatitude);
            double y = 69.1 * (office.Longitude - fromLongitude) * Math.Cos(fromLatitude / 57.3);

            // Convert to KM by multiplying 1.609344
            return (Math.Sqrt(x * x + y * y) * 1.609344);
        }
    }
}
