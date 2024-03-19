using ConsoleApp3.Models;

Group group = new Group();

Student student1 = new("Mahammad", "Aliyev", 9);
Student student2 = new("Anar", "Aghayarli", 2);
Student student3 = new("Mirjalal", "Seyidli", 6);
Student student4 = new("Tamerlan", "Ibadov", 3);
Student student5 = new("Rafi", "Mammadov", 7);

group.AddStudent(student1);
group.AddStudent(student2);
group.AddStudent(student3);
group.AddStudent(student4);
group.AddStudent(student5);

group.GetAllStudents();

List<Student> sortedArray = group.Sort();


Console.WriteLine("------------------------------------");

foreach (Student student in sortedArray)
{
    student.ShowInfo();
}

Group group2 = new Group();