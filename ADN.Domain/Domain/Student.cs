using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ADN.Domain.Domain
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }
        public string? Nome { get; set; }
        public int Idade{ get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
