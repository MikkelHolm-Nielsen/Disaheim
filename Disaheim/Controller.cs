using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class Controller
    {
        public List<Book> Books { get; set; }
        public List<Amulet> Amulets { get; set; }
        public List<Course> Courses { get; set; }

        public Controller()
        {
            Books = new List<Book>();
            Amulets = new List<Amulet>();
            Courses = new List<Course>();
        }
        public void AddToList(Book book)
        {
            if (Books != null) { Books.Add(book); }
        }
        public void AddToList(Amulet amulet)
        {
            if (Amulets != null) { Amulets.Add(amulet); }
        }
        public void AddToList(Course course)
        {
            if (Courses != null) { Courses.Add(course); }
        }
    }
}
