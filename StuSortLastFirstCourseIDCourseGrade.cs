﻿using System.Collections.Generic;

namespace tyrone_sortingbasics
{
    class StuSortLastFirstCourseIDCourseGrade : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.LastName.ToUpper() == y.LastName.ToUpper())
                return x.FirstName.ToUpper().CompareTo(y.FirstName.ToUpper());
            else if (x.FirstName.ToUpper() == y.FirstName.ToUpper())
                return x.CourseID.ToUpper().CompareTo(y.CourseID.ToUpper());
            else if (x.CourseID.ToUpper() == y.CourseID.ToUpper() && x.CourseGrade < y.CourseGrade)
                return 1;
            else if (x.CourseID.ToUpper() == y.CourseID.ToUpper() && x.CourseGrade > y.CourseGrade)
                return -1;
            return x.LastName.ToUpper().CompareTo(y.LastName.ToUpper());
        }
    }
}
