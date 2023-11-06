using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

 namespace Shelter.Client
{
    public class PersistencyShelter
    {
        private readonly IMongoCollection<BsonDocument> collection;
        private readonly IMongoClient dbClient;

        public PersistencyShelter()
        {
            string ConnectionString = "mongodb+srv://Umulia:ernice01@cluster0.77eu8xj.mongodb.net";
            dbClient = new MongoClient(ConnectionString);
            IMongoDatabase database = dbClient.GetDatabase("ShelterDB");
            collection = database.GetCollection<BsonDocument>("shelter_minus");
        }

        public List<BsonDocument> GetAll()
        {
            var result = collection.Find(new BsonDocument()).ToList();
            return result;
        }
    }
}
