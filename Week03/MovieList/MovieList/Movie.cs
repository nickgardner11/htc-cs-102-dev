using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string Title;
        public string Director;
        public string Genre;
        public int Length;
        public int ReleaseYear;
        

        public Movie(string title, int releaseYear, string director, string genre, int length)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Length = length;
                Genre = genre;
            Director = director;
}

        public Movie(string title, int releaseYear, int length, string director, string genre)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Length = length;
            Director = director;
            Genre = genre;
        }

        public void ShowDetails()
        {

            MessageBox.Show(Title + " was relased in " + ReleaseYear);
        }
    }
}
