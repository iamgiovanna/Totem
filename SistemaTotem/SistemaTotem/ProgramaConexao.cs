using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SistemaTotem
{
    public class MongoDbConnection
    {
        private readonly IMongoDatabase _database;

        public MongoDbConnection()
        {
            try
            {
                string ConnMongo = "mongodb://localhost:27017";
                var cliente = new MongoClient(ConnMongo);
                _database = cliente.GetDatabase("GACollection_Eventos");
                Console.WriteLine("Conexão estabelecida com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao Mongo.. {ex.Message}");
            }
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName) {
            return _database.GetCollection<T>(collectionName);
         }
    }
}
