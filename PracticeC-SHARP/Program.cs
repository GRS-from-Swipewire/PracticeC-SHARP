using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeC_SHARP
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*int n = 0;
            //string a = "";
            List<Student> listOfStudents = new List<Student>();
            Console.WriteLine("Enter Number of students data you want enter: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Student{i} Data: ");
                Console.WriteLine($"Name: ");
                string s = Console.ReadLine();
                Student ob = new Student(s,i);

                Console.WriteLine($"Enter number of subjects:");
                int numOfSub = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter marks:");
                for (int j = 0; j < numOfSub; j++)
                {
                    ob.addMark(int.Parse(Console.ReadLine()));
                }
                ob.getPercentage();
                Console.WriteLine($"Details of student with ID {ob.id}: \n");
                Console.WriteLine($"name: {ob.name},\n");
                Console.WriteLine($"Percentage: {ob.percentage},\n");
                listOfStudents.Add(ob);
            }*/ //<----class example

            /*new Stack_Queue_Dictionary_Practice();*/
            Interface_And_GetterSetter_Practice ob = new Interface_And_GetterSetter_Practice();
            ob.setDogName("tiger");
            ob.printDogName();
            //new Rough();
        }
    }
}
