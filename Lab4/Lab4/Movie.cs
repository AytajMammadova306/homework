using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Movie
    {
        private string _title;
        private int _duration;//minutes
        private double _rating;

        public void SetMovie(string title, int duration, double rating)
        {
            _title = title;
            _duration = duration;
            _rating = rating;
        }
        public void PrintMovie()
        {
            Console.WriteLine($"Movie {_title} with rating {_rating} is {_duration} minutes long");
        }
    }
}
