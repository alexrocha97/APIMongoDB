using MongoDB.Bson;

namespace MongoDBAPIC.Models
{
    public class Employee
    {
        public ObjectId Id { get; set; }
        public int EmployeeId { get; set; }
        public string Employeenome { get; set; }
        public string Departamento { get; set; }
        public string DataInicio { get; set;}
        public string PhotoFileNome { get; set;}
    }
}
