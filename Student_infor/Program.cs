namespace Student_infor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List_Of_Student list1 = new List_Of_Student();

            Student_infor student1 = new Student_infor("Name: KY ANH");
            Student_infor student2 = new Student_infor("Subject: Programming");
            Student_infor student3 = new Student_infor("Student_ID: BC00690");

            list1.insertStudent(student1);
            list1.insertStudent(student2);
            list1.insertStudent(student3);
            list1.displayStudents();
            Console.WriteLine("-----------------------");

            list1.UpdateStudent(1, "Subject: Economic");
            list1.displayStudents();
            Console.WriteLine("-----------------------");

            list1.RemoveStudent(1);
            list1.displayStudents();
            Console.WriteLine("-----------------------");
        }
    }
}
