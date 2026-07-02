using System.Collections.Immutable;
using System.Net.Http;
using System.Net.Http.Json;

namespace StudentAPIClient
{
    class Program
    {
        static readonly HttpClient httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            httpClient.BaseAddress = new Uri("https://localhost:7026/api/StudentAPI");
            await GetAllStudents();
        }

        static async Task GetAllStudents()
        {
            try
            {
                Console.WriteLine("\n___________________________");
                Console.WriteLine("Get All Students...\n");
                var students = await httpClient.GetFromJsonAsync<List<Student>>("StudentAPI");
                if (students != null)
                {
                    foreach (var student in students)
                    {
                        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; } = 0;
    }
}
