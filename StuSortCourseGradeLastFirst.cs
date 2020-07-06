using System;
using System.Collections.Generic;

namespace tyrone_sortingbasics
{
    class StuSortCourseGradeLastFirst : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.CourseGrade < y.CourseGrade)
                return 1;
            else if (x.CourseGrade > y.CourseGrade)
                return -1;
            else
            {
                if (x.LastName.ToUpper() == y.LastName.ToUpper())
                    return x.FirstName.ToUpper().CompareTo(y.FirstName.ToUpper());
                return x.LastName.ToUpper().CompareTo(y.LastName.ToUpper());
            }
        }
    }
}
