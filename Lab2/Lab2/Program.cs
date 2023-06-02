// See https://aka.ms/new-console-template for more information
using Lab2;




    Console.WriteLine("Hello, World!");
    String connectionString = "Data Source=LAPTOP-276J3PA6;Initial Catalog=WBA_DatabaseConcepts_1_yehia_ali;User ID=sa;Password=SHIMshim99@99";

StudentRepository repository = new StudentRepository(connectionString);

    List<Student> students = repository.GetAllStudents();

    foreach (Student student in students)
    {
        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
    }
