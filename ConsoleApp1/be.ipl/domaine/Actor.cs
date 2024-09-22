using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.be.ipl.domaine
{
    /*internal class Actor
    {
    }*/
    [Serializable]
    public class Actor : Person
    {


        private static readonly long _serialVersionUID = 1L;
        private readonly int _sizeInCentimeter;
        private IList<Movie> _movies;

        public int SizeInCentimeter
        {
            get => _sizeInCentimeter;
        }



        public Actor(string name, string firstname, DateTime birthDate, int sizeInCentimeter)
        {
            //super(name, firstname, birthDate);
            this._sizeInCentimeter = sizeInCentimeter;
            _movies = new List<Movie>();
        }


        //@Override
        public override string toString()
        {
            return "Actor [name = " + getName() + " firstname = " + getFirstname() + " sizeInCentimeter = " + sizeInCentimeter + " birthdate = " + getBirthDate() + "]";
        }

        /**
	     * 
	     * @return list of movies in which the actor has played
	     */
        public Iterator<Movie> Movies()
        {
            return movies.iterator();
        }

        /**
	     * add movie to the list of movies in which the actor has played
	     * @param movie
	     * @return false if the movie is null or already present
	     */
        public boolean addMovie(Movie movie)
        {
            if ((movie == null) || movies.contains(movie))
                return false;

            if (!movie.containsActor(this))
                movie.addActor(this);

            movies.add(movie);

            return true;
        }

        public boolean containsMovie(Movie movie)
        {
            return movies.contains(movie);
        }

        @Override
        public String getName()
        {
            return super.getName().toUpperCase();
        }
    }
}
