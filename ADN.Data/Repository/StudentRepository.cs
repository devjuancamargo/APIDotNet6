using ADN.Domain.Domain;
using ADN.Domain.DTO.Settings;
using ADN.Domain.DTO.Student;
using ADN.Domain.Interfaces.Repository;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ADN.Data.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IMongoCollection<Student> _collection;


        public StudentRepository(IOptions<MongoDbStudentSettings> mongoStudentSettings)
        {
            var mongoClient = new MongoClient(mongoStudentSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(mongoStudentSettings.Value.DatabaseName);
            _collection = mongoDatabase.GetCollection<Student>(mongoStudentSettings.Value.CollectionName);

        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAll()
        {
            var result = await _collection.FindAsync(c => true);
            return result.ToList();
        }

        public Task<Student> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task Insert(Student student)
        {
            await _collection.InsertOneAsync(student);
        }

        public Task Update(string id, StudentInsertDTO student)
        {
            throw new NotImplementedException();
        }
    }
}
