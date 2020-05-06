using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Homework08LinQ
{
    public class DataBase
    {
        public List<Song> Songs;
        public  DataBase() {
         
            //fans

            //songs
            Song song1 = new Song("Heart of Glass", 3, Genre.Rock);
            Song song2 = new Song("Rhiannon", 2, Genre.Rock);
            Song song3 = new Song("Man on the Moon", 2, Genre.Rock);
            Song song4 = new Song("Not Fade Away", 2, Genre.Rock);
            Song song5 = new Song("Breaking Glass", 2, Genre.Rock);
            Song song6 = new Song("Welcome To The Jungle", 5, Genre.Rock);
            Song song7 = new Song("Walk Of Life", 3, Genre.Rock);
            Song song8 = new Song("Smoke on the Water", 2, Genre.Rock);
            Song song9 = new Song("93 'til Infinity", 2, Genre.Techno);
            Song song10 = new Song("Fight the Power", 2, Genre.Techno);
            Song song11 = new Song("The Message", 3, Genre.Techno);
            Song song12 = new Song("Butterfly Effect", 5, Genre.Techno);
            Song song13 = new Song("No Fear", 5, Genre.Techno);
            Song song14 = new Song("Hereditary", 3, Genre.Techno);
            Song song15 = new Song("Bounce Back", 4, Genre.Techno);
            Song song16 = new Song("The Four Seasons", 2520, Genre.Classical);
            Song song17 = new Song("Canon in D major", 376, Genre.Classical);
            Song song18 = new Song("Swan Lake", 461, Genre.Classical);
            Song song19 = new Song("Symphony No. 5", 425, Genre.Classical);
            Song song20 = new Song("Ride of the Valkyries", 608, Genre.Classical);
            Song song21 = new Song("The Magic Flute", 458, Genre.Classical);
            Song song22 = new Song("Carmen Suite No.1", 1, Genre.Classical);
            Song song23 = new Song("Planet E", 1, Genre.Techno);
            Song song24 = new Song("Phasor", 368, Genre.Techno);
            Song song25 = new Song("Counting Comets", 2, Genre.Techno);
            Song song26 = new Song("Cold Summer", 358, Genre.Techno);
            Song song27 = new Song("Destroyer", 2, Genre.Hip_Hop);
            Song song28 = new Song("Phalanx", 2, Genre.Hip_Hop);
            Song song29 = new Song("Vision", 2, Genre.Hip_Hop);
            Song song30 = new Song("Chain Reaction", 1, Genre.Hip_Hop);

             Songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
                                    song8, song9, song10, song11, song12, song13, song14,
                                    song15, song16, song17, song18, song19, song20,
                                    song21, song22, song23, song24, song25, song26, song27, song28, song29, song30 };

            

        }
    }
}
