using System;
using System.Collections.Generic;
using System.Linq;
using Cassandra;

namespace Database
{
    public class DS_CASSANDRA : IPersonDAO
    {
        private Cluster _cluster;
        private ISession _session;

        public void Initialize()
        {
            _cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            _session = _cluster.Connect("local");
        }

        public void Create(Person p)
        {
            _session.Execute("insert into person(id, lname, fname, age) values(" +
                             p.Id + ",'" + p.Lname + "','" + p.Fname + "'," + p.Age + ");");
        }

        public List<Person> Read()
        {
            var query = "SELECT * FROM person";
            var result = _session.Execute(query);
            var rows = result.GetRows().ToList();
            var list = new List<Person>();
            foreach (var row in rows)
                list.Add(new Person(Convert.ToInt32(row["id"]), Convert.ToString(row["lname"]),
                    Convert.ToString(row["fname"]), Convert.ToInt32(row["age"])));
            return list;
        }

        public void Update(Person p)
        {
            _session.Execute("update person set lname = '" + p.Lname + "', fname = '" + p.Fname + "', age = " + p.Age +
                             " where id = " + p.Id + ";");
        }

        public void Delete(Person p)
        {
            _session.Execute("DELETE FROM person WHERE id = " + p.Id + ";");
        }
    }
}