using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_SHARP
{

    public class Student
    {
        //public long mark = 0;
        public string name = "";
        public int id = 0;
        public string percentage = "";
        List<int> marks = new List<int>();
        public Student(string name, int id) {
            this.name = name;
            this.id = id;
        }

        public void addMark(int mark) 
        {
            if(!(mark > 100) || !(mark < 0))
            {
                marks.Add(mark);
            }
        }
       public string getPercentage()
        {
            long sum = 0;
            foreach(int mark in marks)
            {
                sum += mark;
            }
            long totalMarks = marks.Count() * 100;
            percentage = ((sum * 100f)/totalMarks).ToString();
            return percentage;
        }

      public void printDetails()
        {
            Console.WriteLine($"Details of student with ID {id}: \n");
            Console.WriteLine($"name: {name},\n");
            Console.WriteLine($"Percentage: {percentage},\n");
        }
    }
}
