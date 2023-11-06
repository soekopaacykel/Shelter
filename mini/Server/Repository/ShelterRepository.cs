using mini.Repositories;
using mini.Shared.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mini.Repositories;

public class ShelterRepository : IShelter
{
    private const string connectionString =
        @"mongodb+srv://Nicolaiedens:Zhh57jsg@cluster0.wt3rrth.mongodb.net/";

    private const string databaseName = "Shelterdb";
    private const string collectionName = "Shelter";
    private IMongoCollection<Shelter> collection;

    public ShelterRepository()
    {
        var client = new MongoClient(connectionString);
        var database = client.GetDatabase(databaseName);
        collection = database.GetCollection<Shelter>(collectionName);
    }

    // Get all shelters
    public List<Shelter> GetShelters()
    {
        return collection.Find(new BsonDocument()).ToList();
    }

}