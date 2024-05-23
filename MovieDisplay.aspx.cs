using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MoviesDisplayWithLinQ
{
    public partial class MovieDisplay : System.Web.UI.Page
    {
        //method to create list of movies
        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie(101,"Dil Toh Pagal Hai","Romantic", 5));
            movies.Add(new Movie(102, "RaOne", "Sci-Fi", 4.2));
            movies.Add(new Movie(103, "Jawan", "Action", 2.8));
            movies.Add(new Movie(104, "Hera Pheri", "Comedy", 4.7));
            movies.Add(new Movie(105, "Gaddar 2", "Action", 2));
            movies.Add(new Movie(106, "Dunki", "Romantic", 5));
            movies.Add(new Movie(107, "PK", "Action", 5));
            movies.Add(new Movie(108, "Artical 15", "Action", 4));



            return movies;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // dynamic datatype are supported in C#
            List<Movie> tmp = new List<Movie>();

            List<Movie> ds = GetMovies();

            // filtering data - the traditional way
            /*
            foreach(Movie movie in ds)
            {
                if(movie.Rating > 3)
                {
                    tmp.Add(movie);
                }
            }
            */


            // filtering data using LINQ
            var movies = GetMovies();
            var query = from m in movies 
                        where m.Rating > 3 && m.Genre == "Action"
                        orderby m.Rating descending
                        select new { Mname = m.Mname,Rating =  m.Rating };

            // group by query
            var grquery = from m in movies
                          group m by m.Genre into g
                          select new { Genre = g.Key, count = g.Count() };

            GridView2.DataSource = grquery;
            GridView2.DataBind();

            GridView1.DataSource = query;
            GridView1.DataBind();

            MovieGrid.DataSource = ds;
            MovieGrid.DataBind();
        }
    }
}