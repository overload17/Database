using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Database
{

    public class DS_MYSQL : IPersonDAO
    {
        private MySqlConnection _connection;
        private string _database;
        private MySqlDataAdapter _mySqlDataAdapter;
        private string _password;
        private string _server;
        private string _uid;

        public void Initialize()
        {
            _server = "localhost";
            _database = "people";
            _uid = "root";
            _password = "root";
            string connectionString = "SERVER=" + _server + ";" + "DATABASE=" + _database + ";" + "UID=" + _uid + ";" +
                               "PASSWORD=" + _password + ";";
            _connection = new MySqlConnection(connectionString);
        }

        public void Create(Person p)
        {

        }

        public List<Person> Read()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Person p)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Person p)
        {
            throw new System.NotImplementedException();
        }
    }
}
