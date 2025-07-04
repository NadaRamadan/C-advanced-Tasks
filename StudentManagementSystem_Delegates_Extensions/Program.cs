namespace StudentManagementSystem_Delegates_Extensions
{
    public delegate bool filter(Student student);

    public class Program
    {
        public static List<Student> FilterStudents(List<Student> students, filter StudentFilter)
        {
            List<Student> result = new List<Student>();
            foreach (Student student in students)
            {
                if (StudentFilter(student)) {
                    result.Add(student);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<Student> students_list = new List<Student> {
                new Student("Nada",new List<int> { 90, 100, 85 }),
                new Student("Amira",new List<int> { 60,80,100}),
            new Student("Omar",new List<int>{ 0,10,5})
                };

           List<Student> highScore =FilterStudents (students_list, s => s.Scores.AverageScore()>80);
            foreach (Student student in highScore)
            {
                Console.WriteLine(student);
            }
            List<Student> startWithA = FilterStudents(students_list, s => s.Name.StartsWith("A"));

            foreach (Student student in startWithA)
            {
                Console.WriteLine(student);
            }

        }
    }
}
