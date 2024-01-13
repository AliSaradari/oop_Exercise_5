using OOP_Exercise_5;

while (true)
{
    try
    {
        Run();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
static void Run()
{
    Console.WriteLine("Choose An option:\n" +
        "1.Add Student\n" +
        "2.Show Students\n" +
        "3.Enter Student Courses\n" +
        "4.Calculate Student Tuition\n" +
        "0.Exit");
    var menu = int.Parse(Console.ReadLine());
    switch (menu)
    {
        case 0:
            {
                Environment.Exit(0);
                break;
            }
        case 1:
            {
                var studentUniType = GetInt("Choose Student University:\n" +
                    "1.Public University\n2.Private University");
                var studentId = GetString("Enter Student Id:");
                var studentFieldOption = GetInt("Choose Student Field:\n" +
                    "1.Engineering\n" +
                    "2.Medical\n");
                University.AddStudent(studentUniType, studentId, studentFieldOption);
                break;
            }

        case 2:
            {
                University.ShowStudents();
                break;
            }
        case 3:
            {
                var studentId = GetString("Enter Student Id:");
                var courseName = GetString("Enter Course Name:");
                var courseUnits = GetInt("Enter Number of Course Units");
                University.SetStudentCourse(studentId, courseName, courseUnits);
                break;
            }
        case 4:
            {
                var studentId = GetString("Enter Student Id:");
                University.ShowTuition(studentId);
                break;
            }
        case 5:
            {
                break;
            }
    }
}
static string? GetString(string message)
{
    Console.WriteLine(message);
    var input = Console.ReadLine();
    return input;
}
static int GetInt(string message)
{
    Console.WriteLine(message);
    var input = int.Parse(Console.ReadLine());
    return input;
}