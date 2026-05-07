using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteCvp.Domain;
using SteCvp.Infrastructure.Database;


namespace SteCvp.Infrastructure.Repositories
{
    public class StudentRepository : Repository

    {
        public StudentRepository(DbConnectionFactory connectionFactory) : base(connectionFactory)
        {

        }

        public IEnumerable<Student> GetAll() // LEEST data uit de database en geeft een lijst van studenten terug
        {
            using var connection = _connectionFactory.CreateConnection();

            string sql = @"SELECT studentId AS Id,FirstName, LastName FROM Students;";

            return connection.Query<Student>(sql).ToList();
        }

        public void Add(Student student) // VOEGT een nieuwe student toe aan de database
        {
            using var connection = _connectionFactory.CreateConnection();

            string sql = @"INSERT INTO Students (FirstName, LastName) VALUES (@FirstName, @LastName);";

            connection.Execute(sql, new { FirstName = student.FirstName, LastName = student.LastName });
        }
    }
}
