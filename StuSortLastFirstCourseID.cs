using System.Collections.Generic;

namespace tyrone_sortingbasics
{
    class StuSortLastFirstCourseID : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.LastName.ToUpper() == y.LastName.ToUpper())
                return x.FirstName.ToUpper().CompareTo(y.FirstName.ToUpper());
            else if (x.FirstName.ToUpper() == y.FirstName.ToUpper())
                return x.CourseID.ToUpper().CompareTo(y.CourseID.ToUpper());
            return x.LastName.ToUpper().CompareTo(y.LastName.ToUpper());
        }
    }
}
