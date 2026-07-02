using StudentAPI.Models;

namespace StudentAPI.DataSimulation
{
    public class StudentDataSimulation
    {
        public static readonly List<Student> StudentsList = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Age = 20, Grade = 90 },
            new Student { Id = 2, Name = "Bob", Age = 22, Grade = 85 },
            new Student { Id = 3, Name = "Charlie", Age = 21, Grade = 88 },
            new Student { Id = 4, Name = "David", Age = 23, Grade = 92 },
            new Student { Id = 5, Name = "Eve", Age = 20, Grade = 87 }
        };
    }
}
