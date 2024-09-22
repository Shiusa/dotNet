using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.be.ipl.domaine
{
    /*internal class Director
    {
    }*/
    [Serializable]
    public class Director : Person
    {


        private static readonly long _serialVersionUID = 5952964360274024205L;
        private IList<Movie> _directedMovies;

        public Director(string name, string firstname, DateTime birthDate) : base(name, firstname, birthDate)
        {
            //super(name, firstname, birthDate);
            _directedMovies = new List<Movie>();
        }

        public bool addMovie(Movie movie)
        {

            if (_directedMovies.contains(movie))
                return false;

            if (movie.Director() == null)
                movie.setDirector(this);

            _directedMovies.add(movie);

            return true;

        }

        public Iterator<Movie> Movies()
        {
            return directedMovies.iterator();
        }


    }
}
