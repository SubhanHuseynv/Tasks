using ADO.NET.Data;
using ADO.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Services
{
    internal class StudentService
    {
        private static Sql _sql=new();
        public List<Student> GetStudentById(int id)
        {
            DataTable table = _sql.QueryEx($"SELECT * FROM Students WHERE Id={id}");

            List<Student> list = new List<Student>();

            foreach (DataRow row in table.Rows)
            {
                Student student = new Student
                {
                    Id = (int)row["Id"],
                    Name = row["Name"].ToString(),
                    Surname = row["Surname"].ToString(),
                    Age = (int)(row["Age"])
                };

                list.Add(student);
            }
            return list;
        }
        public void Update(Student student)
        {
            int result=_sql.NonQueryEx($"UPDATE Students SET Name = '{student.Name}', Surname = '{student.Surname}', Age = {student.Age} WHERE Id = {student.Id}");
            if(result == 0)
            {
                Console.WriteLine("Something goes wrong");
            }
            else
            {
                Console.WriteLine("Completely succesfuly");
            }
        }
        public void Remove(int id)
        {
            int result=_sql.NonQueryEx($"DELETE FROM Students WHERE Id = {id}");
            if(result == 0)
            {
                Console.WriteLine("Error occured");
            }
            else
            {
                Console.WriteLine("Completed succesfully");
            }
        }
    }
}
