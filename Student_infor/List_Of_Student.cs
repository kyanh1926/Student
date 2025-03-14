using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_infor 
{
    internal class List_Of_Student
    {
        List<Student_infor> students = new List<Student_infor>();
        public void insertStudent(Student_infor student)
        {
            students.Add(student);
        }

        public void displayStudents()
        {
            int i = 1;
            foreach (var student in students)
            {

                Console.Write(i + ": ");
                Console.WriteLine(student.getDescription());
                i++;
            }
        }

        public void UpdateStudent(int i, string updateDescription)
        {
            if (i >= 0 && i < students.Count) 
            {
                students[i].setDescription(updateDescription);
            }
            else
            {
                Console.WriteLine("Error: Invalid index.");
            }
        }

        public void RemoveStudent(int i)
        {
            if (i >= 0 && i < students.Count) 
            {
                students.RemoveAt(i);
            }
            else
            {
                Console.WriteLine("Error: Invalid index.");
            }
        }
    }
}
