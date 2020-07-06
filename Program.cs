using System;
using System.Collections.Generic;

namespace tyrone_sortingbasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.getTestStudents();

            Console.WriteLine(Student.SortTitle("Not Sorted"));
            Console.WriteLine(Student.ColumnHeader());

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(Student.SortTitle("Sorted by Last Name and First Name Using Built in IComparable"));
            Console.WriteLine(Student.ColumnHeader());
            students.Sort();


            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(Student.SortTitle("Sorted by Course Grade, Last Name, and then First Name Using IComparer"));
            Console.WriteLine(Student.ColumnHeader());

            students.Sort(new StuSortCourseGradeLastFirst());

            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(Student.SortTitle("Sorted by Last Name, First Name and then CourseID Using IComparer"));
            Console.WriteLine(Student.ColumnHeader());

            students.Sort(new StuSortLastFirstCourseID());

            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(Student.SortTitle("Sorted  by Last Name, First Name and then CourseID and then CourseGrade Using IComparer"));
            Console.WriteLine(Student.ColumnHeader());

            students.Sort(new StuSortLastFirstCourseIDCourseGrade());

            foreach (Student s in students)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nPress <ENTER> to quit...");
            Console.ReadKey();
        }

    }
}
