using System;
using System.Collections.Generic;

namespace lab01_9033_OOP
{
    class Tester
    {
        static Student Input()
        {
            Console.WriteLine("-----------------");
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter khoa: ");
            string khoa = Console.ReadLine();
            Console.Write("Enter SID: ");
            string SID = Console.ReadLine();
            Console.Write("Enter GPA: ");
            if (int.TryParse(Console.ReadLine(), out int GPA))
            {
                return new(name, khoa, SID, GPA);
            }
            throw new Exception("GPA must be a number");
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter n: ");
                if (!int.TryParse(Console.ReadLine(), out int n))
                {
                    throw new Exception("GPA must be a number");
                }
                List<Student> listStudent = new();
                for (int i = 0; i < n; i++)
                {
                    listStudent.Add(Input());
                }
                Console.WriteLine("----------------------");
                Console.WriteLine("List student:");
                foreach (var item in listStudent)
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
