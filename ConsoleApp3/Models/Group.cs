namespace ConsoleApp3.Models
{
    internal class Group
    {
        public Group()
        {
            StaticNo++;
            No = $"{GroupName}{StaticNo}";
        }
        private const string GroupName = "AP";
        private static int StaticNo { get; set; }
        private string No { get; set; }
        private List<Student> Students { get; set; } = new List<Student>();
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void GetAllStudents()
        {
            foreach (Student student in Students)
            {
                student.ShowInfo();
            }
        }
        public List<Student> Sort()
        {
            List<Student> sortedStudents = new List<Student>();
            sortedStudents.AddRange(Students);
            bool isChanged = true;
            while (isChanged)
            {
                isChanged = false;
                for (int i = 0; i < sortedStudents.Count - 1; i++)
                {
                    if (sortedStudents[i] > sortedStudents[i + 1])
                    {
                        Student temp = sortedStudents[i];
                        sortedStudents[i] = sortedStudents[i + 1];
                        sortedStudents[i + 1] = temp;
                        isChanged = true;
                    }
                }
            }
            return sortedStudents;
        }
    }
}
