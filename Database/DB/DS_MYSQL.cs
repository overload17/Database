using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Database
{
    public class DS_MYSQL : IPersonDAO
    {
        private MySqlConnection _connection;

        public void Initialize()
        {
            string _server = "localhost";
            string _database = "people";
            string _uid = "root";
            string _password = "root";
            var connectionString = "SERVER=" + _server + ";" + "DATABASE=" + _database + ";" + "UID=" + _uid + ";" +
                                   "PASSWORD=" + _password + ";";
            _connection = new MySqlConnection(connectionString);
        }

        public void Create(Person p)
        {
            try
            {
                _connection.Open();
                var query = "insert into persons(id, last_name, first_name, age) values('" +
                            p.Id + "','" + p.Lname + "','" + p.Fname + "','" + p.Age + "');";
                var myCommand = new MySqlCommand(query, _connection);
                myCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _connection.Close();
        }

        public List<Person> Read()
        {
            var list = new List<Person>();
            var Query = "SELECT * FROM persons";
            _connection.Close();
            var myCommand = new MySqlCommand(Query, _connection);
            _connection.Open();
            var reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                var p = new Person
                {
                    Id = Convert.ToInt32(reader["id"].ToString()),
                    Lname = reader["last_name"].ToString(),
                    Fname = reader["first_name"].ToString(),
                    Age = Convert.ToInt32(reader["age"].ToString())
                };
                list.Add(p);
            }
            _connection.Close();
            return list;
        }

        public void Update(Person p)
        {
            try
            {
                var query = "update persons set id='" + p.Id + "',last_name='" +
                            p.Lname + "',first_name='" + p.Fname + "',age='" +
                            p.Age + "' where id='" + p.Id + "';";
                var myCommand = new MySqlCommand(query, _connection);
                _connection.Open();
                var myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete(Person p)
        {
            try
            {
                var query = "delete from persons where id='" + p.Id + "';";
                var myCommand = new MySqlCommand(query, _connection);
                _connection.Open();
                var myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                }
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}