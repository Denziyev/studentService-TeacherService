using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Abstractions;
using TaskApp.Abstractions.Baseİservice;
using TaskApp.Core.Models;

namespace TaskApp.Services
{
    public class StudentService : İStudentService, IService
    {
        Student[] students = { };
        public void Create()
        {
            Student student = new Student();
            Console.WriteLine("Student Name daxin edin: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Student Surname daxil edin: ");
            student.Surname = Console.ReadLine();
            Console.WriteLine("Student GroupNumber daxil edin: ");
            student.GroupNumber = Console.ReadLine();
            if(student.Name.Length > 2 && student.Surname.Length > 2 && student.Name.Length < 31 && student.Surname.Length < 31 && student.GroupNumber.Length > 0)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Name ve Surname 3-30 simvol olmalidir");
                Create();
            }
            
        }

        public void GetById()
        {
            if(students.Length == 0)
            {
                Console.WriteLine("Hec bir melumat movcud deyil");
            }
            else
            {
                Console.WriteLine("Id daxil edin:");
                int id = int.Parse(Console.ReadLine());
                if(id > 0)
                {
                    for (int i=0;i<students.Length;i++)
                    {
                        if (students[i].Id == id)
                        {
                            Console.WriteLine(students[i]);
                        }
                        else if (i == students.Length - 1)
                        {
                            Console.WriteLine("Bele Id movcud deyil");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Bele Id movcud deyil");
                }
            }          
        }

        public void Show()
        {
            if (students.Length == 0)
            {
                Console.WriteLine("Hec bir melumat movcud deeyil");
            }
            else
            {
                foreach (Student student in students)
                {
                    Console.WriteLine(student);
                }

            }
        }

        public void Delete()
        {
            if (students.Length == 0)
            {
                Console.WriteLine("Hecbir melumat movcud deyil");
            }
            else
            {
                Console.WriteLine("Delete etmek istediyiniz Id-ni daxil edin: ");
                int delid = int.Parse(Console.ReadLine());
                if (delid >= 0)
                {

                    for (int i = delid; i < students.Length; i++)
                    {
                        students[i - 1] = students[i];
                    }
                    Array.Resize(ref students, students.Length - 1);
                    Console.WriteLine("Delete Student emeliyyati ugurla bitdi");
                }
                else
                {
                    Console.WriteLine("Bele id movcud deyil");
                }

            }
        }



        public Student[] EditData()
        {
            if(students.Length == 0)
            {
                Console.WriteLine("hec bir melumat movcud deyil");
            }
            else
            {
                Console.WriteLine("Edit etmek istediyiniz Id-ni daxil edin: ");
                int edid = int.Parse(Console.ReadLine());
                if(edid >= 0)
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        if (students[i].Id == edid)
                        {
                            Console.WriteLine("Bu ID haqqinda melumat tapildi");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Enter 0 for exit edit operation");
                            Console.WriteLine("Enter 1 for edit Name");
                            Console.WriteLine("Enter 2 for edit Surname");
                            Console.WriteLine("Enter 3 for edit GroupNumber");
                            string request = Console.ReadLine();
                            while (request != "0")
                            {
                                switch (request)
                                {
                                    case "1":
                                        Console.WriteLine("Enter the new Name:");
                                        students[i].Name = Console.ReadLine();
                                        break;
                                    case "2":
                                        Console.WriteLine("Enter the new Surname:");
                                        students[i].Surname = Console.ReadLine();
                                        break;
                                    case "3":
                                        Console.WriteLine("Enter the new GroupNumber");
                                        students[i].GroupNumber = Console.ReadLine();
                                        break;
                                }
                                Console.WriteLine("Enter 0 for exit edit operation");
                                Console.WriteLine("Enter 1 for edit Name");
                                Console.WriteLine("Enter 2 for edit Surname");
                                Console.WriteLine("Enter 3 for edit GroupNumber");
                                request = Console.ReadLine();
                            }
                            
                        }
                        else if(i==students.Length-1)
                        {
                            Console.WriteLine("Not found this Id");
                        }

                    }

                }
                else
                {
                    Console.WriteLine("Bele Id movcud deyil");
                }
            }            
            return students;
        }       
    }
}
