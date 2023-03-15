using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Core.Models;

namespace TaskApp.Services
{
    internal class TeacherService
    {
        Teacher[] teachers = { };
        public void Create()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("Teacher Name daxin edin: ");
            teacher.Name = Console.ReadLine();
            Console.WriteLine("Student Surname daxil edin: ");
            teacher.Surname = Console.ReadLine();
            Console.WriteLine("Student GroupNumber daxil edin: ");
            teacher.GroupNumber = Console.ReadLine();
            if (teacher.Name.Length > 2 && teacher.Surname.Length > 2 && teacher.Name.Length < 31 && teacher.Surname.Length < 31 && teacher.GroupNumber.Length > 0)
            {
                Array.Resize(ref teachers, teachers.Length + 1);
                teachers[teachers.Length - 1] = teacher;

            }
            else
            {
                Console.WriteLine("Name ve Surname 3-30 simvol olmalidi.Yeniden cehd edin");
                Create();
            }
        }

        public void GetById()         
        {
            if(teachers.Length == 0)
            {
                Console.WriteLine("Hec bir melumat movcud deyil");
            }
            else
            {
                Console.WriteLine("Id daxil edin:");
                int id = int.Parse(Console.ReadLine());
                if(id > 0)
                {
                    for (int i=0;i<teachers.Length;i++)
                    {
                        if (teachers[i].Id == id)
                        {
                            Console.WriteLine(teachers[i]);
                        }
                        else if (i == teachers.Length - 1)
                        {
                            Console.WriteLine("Bele Id movcud deyil");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Bele Id mocvud deyil");
                }
            }            
        }

        public void Show()
        {
            if (teachers.Length == 0)
            {
                Console.WriteLine("Hec bir melumat movcud deyil");
            }
            else foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher);
            }

        }

        public void Delete()
        {
            if (teachers.Length == 0)
            {
                Console.WriteLine("Hecbir melumat movcud deyil");
            }
            else
            {
                 Console.WriteLine("Delete etmek istediyiniz Id-ni daxil edin: ");
                 int delid = int.Parse(Console.ReadLine());
                if (delid >= 0 )
                {

                    for (int i = delid; i < teachers.Length; i++)
                    {
                      teachers[i - 1] = teachers[i];
                    }
                    Array.Resize(ref teachers, teachers.Length - 1);
                    Console.WriteLine("Delete Teacher emeliyyati ugurla bitdi");
                }
                else
                {
                    Console.WriteLine("Bele id movcud deyil");
                }

            }
        }

        public Teacher[] EditData()
        {
            if(teachers.Length == 0)
            {
                Console.WriteLine("hec bir mwlumat movcud deyil");
            }
            else
            {
                Console.WriteLine("Edit etmek istediyiniz Id-ni daxil edin: ");
                int edid = int.Parse(Console.ReadLine());
                if( edid >= 0 )
                {
                    for (int i = 0; i < teachers.Length; i++)
                    {
                        if (teachers[i].Id == edid)
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
                                        teachers[i].Name = Console.ReadLine();
                                        break;
                                    case "2":
                                        Console.WriteLine("Enter the new Surname:");
                                        teachers[i].Surname = Console.ReadLine();
                                        break;
                                    case "3":
                                        Console.WriteLine("Enter the new GroupNumber");
                                        teachers[i].GroupNumber = Console.ReadLine();
                                        break;
                                }
                                Console.WriteLine("Enter 0 for exit edit operation");
                                Console.WriteLine("Enter 1 for edit Name");
                                Console.WriteLine("Enter 2 for edit Surname");
                                Console.WriteLine("Enter 3 for edit GroupNumber");
                                request = Console.ReadLine();
                            }
                            
                        }
                        else if(i==teachers.Length-1)
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
            return teachers;
        }
    }
}
