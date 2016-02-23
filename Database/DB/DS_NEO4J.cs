using System;
using System.Collections.Generic;
using System.Linq;
using Neo4jClient;

namespace Database
{
    public class DS_NEO4J : IPersonDAO
    {
        public GraphClient client;

        public void Initialize()
        {
            client = new GraphClient(new Uri("http://neo4j:root@localhost.:7474/db/data"));
            client.Connect();
        }

        public void Create(Person p)
        {
            var newUser = new Person {Id = p.Id, Fname = p.Fname, Age = p.Age, Lname = p.Lname};
            client.Cypher
                .Create("(person:Person {newUser})")
                .WithParam("newUser", newUser)
                .ExecuteWithoutResults();
        }

        public List<Person> Read()
        {
            var data = client.Cypher.Match("(p:Person)").Return<Person>("p").Results.ToList();
            return data;
        }


        public void Update(Person p)
        {
            client.Cypher
                .Match("(person:Person)")
                .Where((Person person) => person.Id == p.Id)
                .Set("person = {Person}")
                .WithParam("Person", new Person {Id = p.Id, Fname = p.Fname, Age = p.Age, Lname = p.Lname})
                .ExecuteWithoutResults();
        }

        public void Delete(Person p)
        {
            client.Cypher
                .Match("(person:Person)")
                .Where((Person person) => person.Id == p.Id)
                .Delete("person")
                .ExecuteWithoutResults();
        }
    }
}