using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Database
{
    public class DS_MSSQL : IPersonDAO
    {
        private SqlConnection _connection;
        private string _database;
        private string _server;

        public void Initialize()
        {
            _server = "OVERLOAD-ПК";
            _database = "people";
            var connectionString = "Data Source=" + _server + ";" + "Initial Catalog=" + _database + ";" +
                                   "Integrated Security=SSPI;";
            _connection = new SqlConnection(connectionString);
        }

        public void Create(Person p)
        {
            _connection.Open();
            var sql = string.Format("Insert Into persons" +
                                    "(id, lname, fname, age) Values(@id, @lname, @fname, @age)");

            using (var cmd = new SqlCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("@id", p.Id);
                cmd.Parameters.AddWithValue("@lname", p.Lname);
                cmd.Parameters.AddWithValue("@fname", p.Fname);
                cmd.Parameters.AddWithValue("@age", p.Age);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Person> Read()
        {
            var da = new SqlDataAdapter("select * from persons", _connection);
            var ds = new DataSet();
            da.Fill(ds);
            var myData =
                ds.Tables[0].AsEnumerable()
                    .Select(
                        r =>
                            new Person(r.Field<int>("id"), r.Field<string>("lname"), r.Field<string>("fname"),
                                r.Field<int>("age")));
            return myData.ToList();
        }

        public void Update(Person p)
        {
            _connection.Open();
            var sql = string.Format("Update persons Set lname = '{0}', fname = '{1}', age = '{2}' Where id = '{3}'",
                p.Lname, p.Fname, p.Age, p.Id);
            using (var cmd = new SqlCommand(sql, _connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(Person p)
        {
            _connection.Open();
            var sql = string.Format("Delete from persons where id = '{0}'", p.Id);
            using (var cmd = new SqlCommand(sql, _connection))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    var error = new Exception("К сожалению ошибка.", ex);
                    throw error;
                }
            }
        }
    }
}