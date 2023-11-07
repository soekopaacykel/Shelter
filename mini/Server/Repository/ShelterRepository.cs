using mini.Repositories;
using mini.Shared.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mini.Repositories;

public class ShelterRepository : IShelter
{
    private const string connectionString =
        @"mongodb+srv://casper:Casperemil123@cluster0.77eu8xj.mongodb.net/";

    private const string databaseName = "ShelterDB";
    private const string collectionName = "shelter_beskr";
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