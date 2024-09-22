using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.be.ipl.domaine
{
    /*internal class Movie
    {
    }*/
    public class Movie
    {

        private string _title;
        private int _releaseYear;
        private IList<Actor> _actors;
        private Director _director;

        public Movie(string title, int releaseYear)
        {
            _actors = new List<Actor>();
            this._title = title;
            this._releaseYear = releaseYear;
        }

        /*public Director getDirector
        {
            get => _director;
        }*/
        public Director Director
        {
            get
            {
                return _director;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                _director = value;
                _director.addMovie(this);
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        /*public void setTitle(String title)
        {
            this.title = title;
        }*/
        public int getReleaseYear()
        {
            return releaseYear;
        }
        public void setReleaseYear(int releaseYear)
        {
            this.releaseYear = releaseYear;
        }

        public boolean addActor(Actor actor)
        {
            if (actors.contains(actor))
                return false;

            actors.add(actor);
            if (!actor.containsMovie(this))
                actor.addMovie(this);

            return true;
        }

        public boolean containsActor(Actor actor)
        {
            return actors.contains(actor);
        }

        @Override
        public String toString()
            {
                return "Movie [title=" + title + ", releaseYear=" + releaseYear + "]";
            }



        }
}
