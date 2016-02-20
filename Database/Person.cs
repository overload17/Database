namespace Database
{
    public class Person
    {
        public int Age;
        public string Fname;
        public int Id;
        public string Lname;

        public Person(int id, string lname, string fname, int age)
        {
            Id = id;
            Lname = lname;
            Fname = fname;
            Age = age;
        }
    }
}