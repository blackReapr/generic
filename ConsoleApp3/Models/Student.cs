namespace ConsoleApp3.Models
{
    internal class Student
    {
        public Student(string name, string surname, double point)
        {
            StaticId++;
            Id = StaticId;
            Name = name.Trim();
            Surname = surname.Trim();
            Point = point;
        }
        private static int StaticId { get; set; }
        private int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Point { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"{Id}: {Name} {Surname}. Age: {Age}. Point: {Point}");
        }


        public static bool operator >  (Student a, Student b)
        {
            return a.Point > b.Point ? true : false;
        }
        public static bool operator < (Student a, Student b)
        {
            return a.Point < b.Point ? true : false;
        }

    }
}
