using System.Collections.Generic;
using StackExchange.Redis;

namespace Database
{
    public class DS_REDIS : IPersonDAO
    {
        private static ConnectionMultiplexer connectionMultiplexer;
        private static IDatabase database;

        public void Initialize()
        {
            connectionMultiplexer = ConnectionMultiplexer.Connect("localhost");
            database = connectionMultiplexer.GetDatabase();
        }

        public void Create(Person p)
        {
            database.ListRightPush("Id", p.Id);
            database.ListRightPush("Fname", p.Fname);
            database.ListRightPush("Lname", p.Lname);
            database.ListRightPush("Age", p.Age);
        }

        public List<Person> Read()
        {
            var list = new List<Person>();
            var ids = database.ListRange("Id");
            var firstNames = database.ListRange("Fname");
            var lastNames = database.ListRange("Lname");
            var ages = database.ListRange("Age");
            for (var i = 0; i < ids.Length; i++)
            {
                list.Add(new Person(int.Parse(ids[i].ToString()), firstNames[i].ToString(), lastNames[i].ToString(),
                    int.Parse(ages[i].ToString())));
            }
            return list;
        }

        public void Update(Person p)
        {
            var ids = database.ListRange("Id");
            for (var i = 0; i < ids.Length; i++)
            {
                if (int.Parse(ids[i].ToString()) == p.Id)
                {
                    database.ListSetByIndex("Fname", i, p.Fname);
                    database.ListSetByIndex("Lname", i, p.Lname);
                    database.ListSetByIndex("Age", i, p.Age);
                }
            }
        }

        public void Delete(Person p)
        {
            var ids = database.ListRange("Id");
            var firstNames = database.ListRange("Fname");
            var lastNames = database.ListRange("Lname");
            var ages = database.ListRange("Age");
            for (var i = 0; i < ids.Length; i++)
            {
                if (int.Parse(ids[i].ToString()) == p.Id)
                {
                    database.ListRemove("Id", ids[i]);
                    database.ListRemove("Fname", firstNames[i]);
                    database.ListRemove("Lname", lastNames[i]);
                    database.ListRemove("Age", ages[i]);
                }
            }
        }
    }
}