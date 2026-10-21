using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();
        private Utility utility = new Utility();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course? GetCourse(string name)
        {
            foreach (Course course in courses)
            {
                if (course.Name == name)
                { return course; }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;
            foreach (Course course in courses)
            {
                total += utility.GetValueOfCourse(course);
            }
            return total;
        }
        //git test

    }
}

