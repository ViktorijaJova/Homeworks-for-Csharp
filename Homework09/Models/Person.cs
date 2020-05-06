using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework08LinQ
{
     public class Person { 
    
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Genre FavoriteMusicType { get; set; }

        public List<Song> FavoriteSongs { get; set; }

        public Person(long id, string firstname, string lastname, int age , Genre favoriteMusicType)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = new List<Song>();
        }


        public void GetFavSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine($"{FirstName}{LastName} hates music and has no soul");
            }
            else
            {
                Console.WriteLine("List of favorite songs:");
                foreach (Song song in FavoriteSongs)

                {
                    Console.WriteLine(song.Title);
                }

            }
        }


    }
}
