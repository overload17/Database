using System.Collections.Generic;

namespace Database
{
    public interface IPersonDAO
    {
        void Initialize();
        void Create(Person p);
        List<Person> Read();
        void Update(Person p);
        void Delete(Person p);
    }
}