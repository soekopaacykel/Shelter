using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mini.Shared.Models;

public class Shelter
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    [BsonElement("name")]
    public string name { get; set; } = string.Empty; // Changed property name to match your provided data

    [BsonElement("image")]
    public string image { get; set; } = string.Empty;

    [BsonElement("location")]
    public string location { get; set; } = string.Empty;

    [BsonElement("capacity")]
    public string capacity { get; set; } = string.Empty; // Assuming capacity is an integer

    [BsonElement("description")]
    public string description { get; set; } = string.Empty;
}
