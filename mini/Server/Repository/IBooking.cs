namespace mini.Repositories
{
    using mini.Shared.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetAllBookings();
        Task AddBooking(Booking booking);
    }
}