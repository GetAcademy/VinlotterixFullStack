using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using VinlotterixFullStack.Model;

namespace SqlTestVinlotterix
{
    class PersonRepository
    {
        private SqlConnection _conn;

        public PersonRepository()
        {
            var connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Vinlotterix;Integrated Security=True";
            _conn = new SqlConnection(connStr);
        }

        public List<Person> Get()
        {
            return _conn.Query<Person>("select * from personx").ToList();
        }

        public int Create(Person person)
        {
            return _conn.Execute("INSERT INTO Personx VALUES (@Id, @Name)", person);
        }

        public int Update(Person person)
        {
            return _conn.Execute("update personx set name = @Name where id = @Id", person);
        }

        public int Delete(Person person)
        {
            return _conn.Execute("DELETE FROM Personx WHERE Id = @Id", person);
        }

        public int Delete(Guid id)
        {
            return _conn.Execute("DELETE FROM Personx WHERE Id = @Id", new {Id=id});
        }
    }
}
