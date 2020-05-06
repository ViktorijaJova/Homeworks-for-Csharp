using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework08LinQ
{
    class Program
    {
        static void Main(string[] args)
        {

            var personrepository = new PersonRepository();


            //first task
            Song firstfavorite= new Song("Heart of Glass", 3, Genre.Rock);
            Song secondfavorite = new Song("Rhiannon", 2, Genre.Rock);
            Song thirdfavorite = new Song("Man on the Moon", 2, Genre.Rock);
            List<Song> topthreelist = new List<Song>() { firstfavorite, secondfavorite,thirdfavorite };
            Person firstperson = new Person(3852, "Viktorija", "Jovanovska", 23, Genre.Rock);
            firstperson.FavoriteSongs = topthreelist;
            firstperson.GetFavSongs();

            //second task

            List<Person> FansArray = new List<Person>();

            Person Jerry = new Person(1, "Jerry", "Tompson", 78, Genre.Rock);
            Person Stefan = new Person(2, "Stefan", "Stefanoski", 28, Genre.Techno);
            Person Maria = new Person(3, "Maria", "Campbel", 43, Genre.Classical);
            Person Jane = new Person(4, "Jane", "Doe", 28, Genre.Techno);

            FansArray.Add(Jerry);
            FansArray.Add(Stefan);
            FansArray.Add(Maria);
            FansArray.Add(Jane);


            var songsThatStartWithB = personrepository.SongThatStartWithLetterB();
            Jerry.FavoriteSongs = songsThatStartWithB;
            Console.WriteLine("\nPerson Jerry and add all the songs which start with the letter B:");
             Jerry.GetFavSongs();

            var songsLongerThanSixMinutes = personrepository.SongsLongerThan6Min();
            Maria.FavoriteSongs = songsLongerThanSixMinutes;
            Console.WriteLine("\nPerson Maria and add all the songs with length longer than 6 mins");
            Maria.GetFavSongs();

            var songsThatAreGenreRock = personrepository.SongsThatAreGenreRock(Genre.Rock);
            Jane.FavoriteSongs = songsThatAreGenreRock;
            Console.WriteLine("\nJane and add all the songs that are of genre Rock");
            Jane.GetFavSongs();


            var songsThatAre3andHipHop = personrepository.SongsThatAreShorterThan3AndareHipHop(Genre.Hip_Hop);
            Stefan.FavoriteSongs = songsThatAre3andHipHop;
            Console.WriteLine("\nStefan and add all songs shorter than 3 mins and of genre Hip-Hop");
            Stefan.GetFavSongs();




            List<Person> PeopleWith4Songs = FansArray.Where(person => person.FavoriteSongs.Count > 4).ToList();
            foreach(var person in PeopleWith4Songs)
            {
                Console.WriteLine(person.FirstName);
            }



            Console.ReadLine();


        }
    }
}
