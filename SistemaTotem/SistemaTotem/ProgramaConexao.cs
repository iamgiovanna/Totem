using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SistemaTotem
{
    class ProgramaConexao
    {
        private static IMongoCollection<BsonDocument> _collection;


        static async Task Main(string[] args)
        {
            try
            {
                var ConnMongo = "mongodb://localhost:27017";
                var conn = new MongoClient(ConnMongo);
                var database = conn.GetDatabase("App_GremioDB");
                _collection = database.GetCollection<BsonDocument>("GACollection_Eventos");

                var teste = new BsonDocument { { "ping", 1 } };
                await database.RunCommandAsync<BsonDocument>(teste);
                Console.WriteLine("Conexão bem-sucedida!! Pode dar um tempo pra tentar fazer os seus exercícios agora linda");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao Mongo.. {ex.Message}");
            }
        }
    }
}
