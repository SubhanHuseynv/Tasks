using ADO.NET.Data;
using ADO.NET.Models;
using ADO.NET.Services;

namespace ADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sql sql=new Sql();
            //sql.NonQueryEx("INSERT INTO Students VALUES('Subhan','Huseynov',19)");
            //sql.QueryEx("SELECT * FROM Students");




            StudentService studentService = new StudentService();
            //List<Student>list= studentService.GetStudentById(1);
            //foreach (Student student in list)
            //{
            //    Console.WriteLine(student.Name+" "+student.Surname +" "+student.Age);
            //}





            Student student = new Student
            {
                Id=1,
                Name = "Qalib",
                Surname = "Test",
                Age = 24
            };

            studentService.Update(student);
            studentService.Remove(1);


















        }
    }
}
