using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mini.Shared.Models;

public class Shelter
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;

    [BsonElement("navn")]
    public string navn { get; set; } = string.Empty;
}