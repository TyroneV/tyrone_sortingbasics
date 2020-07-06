using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace tyrone_sortingbasics
{
    class Student : IComparable<Student>
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string CourseID { get; set; }
        public float CourseGrade { get; set; }

        public Student(int studentID, string lastName, string firstName, string courseID, float courseGrade)
        {
            StudentID = studentID;
            LastName = lastName;
            FirstName = firstName;
            CourseID = courseID;
            CourseGrade = courseGrade;
        }

        public override string ToString()
        {
            return String.Format("{0,-12:D5}  {1,-12}  {2,-12}  {3,-12}  {4, 12:0.0}", StudentID,LastName,FirstName,CourseID,CourseGrade);
        }

        public static string SortTitle(string title)
        {
            return $"\nSort Type: {title}\n";
        }
        public static string ColumnHeader()
        {
            string a = "Student_ID";
            string b = "Last_Name";
            string c = "First_Name";
            string d = "Course_ID";
            string e = "Course_Grade";
            String s1 = String.Format("{0,-12}  {1,-12}  {2,-12}  {3,-12}  {4,-12}\n",
                a, b, c, d, e);
            string s2 = s1;
            Regex pattern = new Regex("\\w");
            s2 = pattern.Replace(s2, "=");
            s1 = s1.Replace("_", " ");
            return s1 + s2;
        }
        public static List<Student> getTestStudents()
        {
            // For testing purposes some duplicate student infomation will be used.

            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Jones", "Joan", "art0024", 3.0f));
            students.Add(new Student(2, "Einstein", "Jose", "math0001", 3.3f));
            students.Add(new Student(5, "Gonzales", "Miranda", "cs0024", 2.7f));
            students.Add(new Student(4, "Lee", "Kim", "bs0024", 2.7f));
            students.Add(new Student(3, "Jaspers", "Rachel", "cs0001", 2.7f));
            students.Add(new Student(6, "gates", "Bill", "cs0001", 4.0f));
            students.Add(new Student(6, "Gates", "Bill", "art0024", 3.0f));
            students.Add(new Student(6, "Gates", "bill", "art0024", 1.0f));
            students.Add(new Student(7, "Allison", "George", "math0023", 2.7f));
            students.Add(new Student(7, "Allison", "Alice", "cs0001", 2.7f));
            students.Add(new Student(8, "Sills", "Carol", "cs0001", 1.7f));
            students.Add(new Student(8, "Sills", "Albert", "cs0001", 2.7f));
            students.Add(new Student(9, "Starr", "Bert", "chem0020", 3.7f));
            return students;
        }

        public int CompareTo(Student other)
        {
            if (LastName.ToUpper() == other.LastName.ToUpper())
            {
                return FirstName.ToUpper().CompareTo(other.FirstName.ToUpper());
            }
            return LastName.ToUpper().CompareTo(other.LastName.ToUpper());
        }
    }
}
