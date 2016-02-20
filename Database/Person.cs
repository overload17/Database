namespace Database
{
    public class Person
    {
        public int Id;
        public string Lname;
        public string Fname;
        public int Age;

        public Person(int id, string lname, string fname, int age)
        {
            Id = id;
            Lname = lname;
            Fname = fname;
            Age = age;
        }
    }
}
