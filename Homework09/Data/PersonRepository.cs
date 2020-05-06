using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Homework08LinQ
{
    public class PersonRepository : DataBase
    {
        public List<Song> SongThatStartWithLetterB()
        {
            return Songs
           .Where(song => song.Title.ElementAt(0) == 'B')
           .ToList();
        }
        public List<Song> SongsLongerThan6Min()
        {
            return Songs
           .Where(song => song.Length > 6)
           .ToList();
        }

        public List<Song> SongsThatAreGenreRock(Genre genre)
        {
            return Songs
           .Where(song => song.Genre == genre)
           .ToList();
        }

        public List<Song> SongsThatAreShorterThan3AndareHipHop(Genre genre)
        {
            return Songs
                .Where(song => song.Genre == genre && song.Length < 3)
                .ToList();

        }

      

       
    }
}