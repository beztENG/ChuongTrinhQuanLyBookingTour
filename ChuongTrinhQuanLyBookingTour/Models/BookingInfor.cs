namespace ChuongTrinhQuanLyBookingTour.Models
{
    public class BookingInfo
    {
        // Thông tin chung
        public int UserID { get; set; }
        public string BookingType { get; set; } // 'Flight' hoặc 'Hotel'
        public decimal Price { get; set; }

        // Thông tin chuyến bay
        public int? FlightID { get; set; } // FlightID sẽ null nếu là dịch vụ hotel
        public string Airline { get; set; }
        public DateTime? DepartureDate { get; set; }

        // Thông tin khách sạn
        public int? HotelID { get; set; } // HotelID sẽ null nếu là dịch vụ flight
        public string HotelName { get; set; }
        public string Location { get; set; }
        public int? RoomID { get; set; }
        public string RoomType { get; set; }
        public string BedType { get; set; }
        public DateTime? CheckInDate { get; set; }
        // Thông tin tour
        public int TourID { get; set; }
        public string TourName { get; set; }
        public string Starting { get; set; }
        public string Destination { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        
    }
}
