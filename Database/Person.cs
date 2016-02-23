namespace Database
{
    public class Person
    {
        public Person(int id, string lname, string fname, int age)
        {
            Id = id;
            Lname = lname;
            Fname = fname;
            Age = age;
        }

        public Person()
        {
        }

        public int Age { get; set; }
        public string Fname { get; set; }
        public int Id { get; set; }
        public string Lname { get; set; }
    }
}