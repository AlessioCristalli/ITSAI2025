namespace Stradario.Strutture
{
    public class HaversineCalculator
    {
        private const double R = 6371.3;
        public class Haversine
        {
            public static double CalcolaDistanza(double lat1, double lon1, double lat2, double lon2)
            {
                double radLat1 = ToRad(lat1);
                double radLon1 = ToRad(lon1);
                double radLat2 = ToRad(lat2);
                double radLon2 = ToRad(lon2);
                double dLat = radLat2 - radLat1;
                double dLon = radLon2 - radLon1;
                double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                           Math.Cos(radLat1) * Math.Cos(radLat2) *
                           Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
                double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
                return (float)(R * c); // distanza in chilometri
            }
            private static double ToRad(double gradi)
            {
                return gradi * (Math.PI / 180);
            }
        }
    }
}

