namespace Luftreise.Models.Admin;

public class AdminDashboardViewModel
{
    public int TotalUsers { get; set; }
    public int TotalFlights { get; set; }
    public int ActiveFlights { get; set; }
    public int CancelledFlights { get; set; }
}
