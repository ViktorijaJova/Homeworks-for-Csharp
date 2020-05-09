using System;
using System.Collections.Generic;
using System.Text;

namespace TryHomework
{
  public  class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListofMovies { get; set; }

        public Cinema (string name)
        {
            Name = name;
        }
        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"You are watching:{movie.Title}");
        }

    }
}
