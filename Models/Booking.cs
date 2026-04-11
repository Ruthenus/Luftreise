namespace Luftreise_Command_project_.Models
{
    public class BookingViewModel
    {
        public int FlightId { get; set; }

       
        public string Airline { get; set; } = string.Empty;
        public string FlightNumber { get; set; } = string.Empty;
        public string FromCity { get; set; } = string.Empty;
        public string ToCity { get; set; } = string.Empty;
        public string DepartureTime { get; set; } = string.Empty;
        public string ArrivalTime { get; set; } = string.Empty;
        public DateTime FlightDate { get; set; }
        public string FlightClass { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public double BaggageWeight { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string PassportNumber { get; set; } = string.Empty;
    }
}