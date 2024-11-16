using System;

namespace ChuongTrinhQuanLyBookingTour.Helpers
{
    internal class GlobalUserInfo
    {
        public static int UserID { get; set; }
        public static string UserRole { get; set; }
        public static int ProviderID { get; set; }

        // Specific IDs for each provider type
        public static int HotelID { get; set; }
        public static int AirlineID { get; set; }
        public static int CompanyID { get; set; }

        // Additional Airline-specific information
        public static string AirlineName { get; set; }
        public static string AirlineImage { get; set; }

        public static void Clear()
        {
            UserID = 0;
            UserRole = string.Empty;
            HotelID = 0;
            AirlineID = 0;
            CompanyID = 0;
            ProviderID = 0;
        }

    }
}
