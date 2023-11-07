using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mini.Shared.Models;

public class Booking
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = "";

    public string BookingID { get; set; } = "";

    public string Name { get; set; } = string.Empty;

    public DateTime StartDate { get; set; } = DateTime.MinValue;

    public DateTime EndDate { get; set; } = DateTime.MinValue;

    public string Email { get; set; } = string.Empty;

    public string ShelterName { get; set; } = string.Empty;

    // Konstruktør til at oprette en booking
    public Booking(string bookingID = "", string name = "", string email = "", string shelterName="")
    {
        BookingID = bookingID;
        Name = name;
        Email = email;
        ShelterName = shelterName;
    }

}