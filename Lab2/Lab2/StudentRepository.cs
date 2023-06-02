using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lab2
{
    public class StudentRepository
    {
        private readonly string connectionString;

        public StudentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }



        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
       
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name FROM WBA.Students";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"]
                            };

                            students.Add(student);
                        }
                    }
                }
            }

            return students;

        }
        
    }
}
