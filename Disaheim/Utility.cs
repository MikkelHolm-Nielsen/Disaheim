using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            switch (amulet.Quality)
            {
                case Level.Low:
                    return 12.5;
                case Level.Medium:
                    return 20.0;
                case Level.High:
                    return 27.5;
                default:
                    return 0.0;
                
            }
        }

        public double GetValueOfCourse(Course course)
        {
            double HourlyRate = 875;

            int hours = course.DurationInMinutes / 60;
            int remainingMinutes = course.DurationInMinutes % 60;

            if (remainingMinutes > 0) hours += 1;
            return hours * HourlyRate;
        }

    }
} 
