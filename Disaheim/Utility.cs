using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class Utility
    {
        public double LowQualityValue { get; set; } = 12.5;
        public double MediumQualityValue { get; set; } = 20.0;
        public double HighQualityValue { get; set; } = 27.5;
        public double CourseHourValue { get; set; } = 875.0;

        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Book book)
            {
                return book.Price;
            }
            if (merchandise is Amulet amulet)
            {
                switch (amulet.Quality)
                {
                    case Level.Low:
                        return LowQualityValue;
                    case Level.Medium:
                        return MediumQualityValue;
                    case Level.High:
                        return HighQualityValue;
                    default:
                        return 0.0;
                }
            }
            return 0.0;
        }


        /*public double GetValueOfBook(Book book)
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
        }*/

        public double GetValueOfCourse(Course course)
        {
            int hours = course.DurationInMinutes / 60;
            int remainingMinutes = course.DurationInMinutes % 60;

            if (remainingMinutes > 0) hours += 1;
            return hours * CourseHourValue;
        }

    }
}
