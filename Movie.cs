using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesDisplayWithLinQ
{
    public class Movie
    {
        int mid;
        string mname;
        string genre;
        double rating;

        public Movie()
        {
        }

        public Movie(int mid, string mname, string genre, double rating)
        {
            this.mid = mid;
            this.mname = mname;
            this.genre = genre;
            this.rating = rating;
        }

        public int Mid
        {
            get
            {
                return mid;
            }
            set
            {
                mid = value;
            }
        }

        public string Mname
        {
            get
            {
                return mname;
            }
            set
            {
                mname = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }

        public double Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }
    }
}