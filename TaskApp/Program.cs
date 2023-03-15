
using TaskApp.Services;

Console.WriteLine();

StudentService studentService = new StudentService();
TeacherService teacherService = new TeacherService();


Console.WriteLine("Enter 0 for quit");
Console.WriteLine("Enter 1 for new student create");
Console.WriteLine("Enter 2 for show students");
Console.WriteLine("Enter 3 for Search students by Id");
Console.WriteLine("Enter 4 for Delete student by Id");
Console.WriteLine("Enter 5 for Edit student data by Id");
Console.WriteLine("Enter 6 for new teacher create");
Console.WriteLine("Enter 7 for show teachers");
Console.WriteLine("Enter 8 for Search teacher by Id");
Console.WriteLine("Enter 9 for Delete teacher by Id");
Console.WriteLine("Enter 10 for Edit teacher data by Id");

string request = Console.ReadLine();

while (request != "0")
{
    switch (request)
    {
        case "1":
            studentService.Create();
            break;
        case "2":
            studentService.Show();
            break;
        case "3":
            studentService.GetById();
            break;
        case "4":
            studentService.Delete();
            break;
        case "5":
            studentService.EditData();
            break;
        case "6":
            teacherService.Create();
            break;
        case "7":
            teacherService.Show();
            break;
        case "8":
            teacherService.GetById();
            break;
        case "9":
            teacherService.Delete();
            break;
        case "10":
            teacherService.EditData();
            break;
        default: 
            Console.WriteLine("Yalniz 1-10 reqemlerini daxil ede bilersiniz");
            break;

    }
    Console.WriteLine("Enter 0 for quit");
    Console.WriteLine("Enter 1 for new student create");
    Console.WriteLine("Enter 2 for show students");
    Console.WriteLine("Enter 3 for Search students by Id");
    Console.WriteLine("Enter 4 for Delete student by Id");
    Console.WriteLine("Enter 5 for Edit student data by Id");
    Console.WriteLine("Enter 6 for new teacher create");
    Console.WriteLine("Enter 7 for show teachers");
    Console.WriteLine("Enter 8 for Search teacher by Id");
    Console.WriteLine("Enter 9 for Delete teacher by Id");
    Console.WriteLine("Enter 10 for Edit teacher data by Id");
    request = Console.ReadLine();
}