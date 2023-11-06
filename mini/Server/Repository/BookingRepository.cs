namespace mini.Repositories
{
    using mini.Repositories;
    using MongoDB.Driver;
    using mini.Shared.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using MongoDB.Driver.Core.Configuration;
    using System.Collections;

    public class BookingRepository : IBookingRepository
    {
        private readonly IMongoCollection<Booking> _bookings;

        public BookingRepository()
        {
            MongoClient client = new MongoClient(
                @"mongodb+srv://casper:Casperemil123@cluster0.77eu8xj.mongodb.net/");
            IMongoDatabase database = client.GetDatabase("ShelterDB");
            _bookings = database.GetCollection<Booking>("Bookings");
        }

        public async Task<IEnumerable<Booking>> GetAllBookings()
        {
            return await _bookings.Find(_ => true).ToListAsync();
        }

        public async Task AddBooking(Booking booking)
        {
            await _bookings.InsertOneAsync(booking);
        }

    }
}
