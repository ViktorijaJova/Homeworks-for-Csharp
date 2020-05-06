using System;
using System.Collections.Generic;
using System.Text;

namespace Homework08LinQ
{
    public class Song { 
    
        public string Title { get; set; }
        public int Length { get; set; }
        public Genre Genre { get; set; }

        public Song (string title, int lenght, Genre genre)
        {
            Title = title;
            Length = lenght;
            Genre = genre;


          }


    }
}
