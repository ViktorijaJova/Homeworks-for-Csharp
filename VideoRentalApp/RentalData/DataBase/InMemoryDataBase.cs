using sedc.videorental.data.Enums;
using sedc.videorental.data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace sedc.videorental.data.DataBase
{
    public class InMemoryDatabase
    {
        protected List<User> Users { get; set; }
        protected List<Movie> Movies { get; set; }


      
        public InMemoryDatabase()
        {
            InitDatabase();
        }

        private void InitDatabase()
        {
            Users = new List<User>
            {
            new User(){ CardNumber = 111, FullName = "Stan Lee", isAdmin = true},
            new User() { CardNumber = 123, FullName = "Viktorija jovanovska", IsSubscriptionExpired = true },
            new User(){CardNumber= 222, FullName = "Peper Stark" },
            new User(){CardNumber = 333, FullName = "Petar Parker" , IsSubscriptionExpired = true},
            new User(){CardNumber = 323, FullName = "Steve Rogers"},
            new User(){CardNumber = 313, FullName = "Thor " },
            new User(){CardNumber = 303, FullName = "Nebula "},
            new User(){CardNumber = 133, FullName = "Thanos", IsSubscriptionExpired= true},
            new User(){CardNumber = 233, FullName = "Clint Barton"},
            new User() { CardNumber = 113, FullName = "Tony Stark", IsSubscriptionExpired = true}
            };


           
            Movies = new List<Movie>
            {
                new Movie() { Title ="Iron Man", AgeRestriction = 14, Genre = Genre.Action, Id = 1, IsAviable = true, Language = "EN", Length = 180, Quantity = 4, ReleaseDate = new DateTime(2008, 5, 2), Disocunt = Discount.None },
                new Movie() { Title = "The Incredible Hulk", AgeRestriction = 16, Genre = Genre.Action, Id = 2, IsAviable = true, Language = "EN", Length = 220, Quantity = 7, ReleaseDate = new DateTime(2008, 6, 13), Disocunt = Discount.AlmostFree },
                new Movie() { Title = "Iron Man 2", AgeRestriction = 14, Genre = Genre.Action, Id = 3, IsAviable = true, Language = "EN", Length = 120, Quantity = 2, ReleaseDate = new DateTime(2010, 5, 7), Disocunt = Discount.TenPercent },
                new Movie() { Title = "Thor", AgeRestriction = 16, Genre = Genre.Action, Id = 4, IsAviable = true, Language = "EN", Length = 210, Quantity = 2, ReleaseDate = new DateTime(2011, 7, 6),Disocunt = Discount.None  },
                new Movie() { Title = "Captain America: The First Avenger", AgeRestriction = 8, Genre = Genre.Action, Id = 5, IsAviable = true, Language = "EN", Length = 180, Quantity = 1, ReleaseDate = new DateTime(2011, 7, 22),Disocunt = Discount.None  },
                new Movie() { Title = "Marvel's The Avengers", AgeRestriction = 6, Genre = Genre.Action, Id = 6, IsAviable = false, Language = "EN", Length = 160, Quantity = 0, ReleaseDate = new DateTime(2012, 5, 4),Disocunt = Discount.None  },
                new Movie() { Title = "Hot Rod", AgeRestriction = 6, Genre = Genre.Comedy, Id = 7, IsAviable = true, Language = "EN", Length = 111, Quantity = 1, ReleaseDate = new DateTime(2007, 5, 2), Disocunt = Discount.AlmostFree },
                new Movie() { Title = "The First Wives Club", AgeRestriction = 6, Genre = Genre.Comedy, Id = 8, IsAviable = false, Language = "EN", Length = 180, Quantity = 0, ReleaseDate = new DateTime(1996, 5, 2) ,Disocunt = Discount.None },
                new Movie() { Title = "Scary Movie", AgeRestriction = 8, Genre = Genre.Comedy, Id = 9, IsAviable = true, Language = "EN", Length = 200, Quantity = 8, ReleaseDate = new DateTime(2000, 5, 2), Disocunt = Discount.FiftyPercent},
                new Movie() { Title = "The Bank Dick", AgeRestriction = 6, Genre = Genre.Comedy, Id = 10, IsAviable = true, Language = "EN", Length = 140, Quantity = 4, ReleaseDate = new DateTime(1940, 5, 2),Disocunt = Discount.None  },
                new Movie() { Title = "Mrs. Doubtfire", AgeRestriction = 6, Genre = Genre.Comedy, Id = 11, IsAviable = false, Language = "EN", Length = 100, Quantity = 0, ReleaseDate = new DateTime(1993, 5, 2) ,Disocunt = Discount.None },
                new Movie() { Title = "Existenz", AgeRestriction = 14, Genre = Genre.SciFi, Id = 12, IsAviable = true, Language = "EN", Length = 160, Quantity = 2, ReleaseDate = new DateTime(1999, 5, 2),Disocunt = Discount.None  },
                new Movie() { Title = "The Congress", AgeRestriction = 12, Genre = Genre.SciFi, Id = 13, IsAviable = true, Language = "EN", Length = 180, Quantity = 1, ReleaseDate = new DateTime(2014, 5, 2) ,Disocunt = Discount.None },
                new Movie() { Title = "Dark City", AgeRestriction = 10, Genre = Genre.SciFi, Id = 14, IsAviable = true, Language = "EN", Length = 110, Quantity = 7, ReleaseDate = new DateTime(1998, 5, 2), Disocunt = Discount.FiftyPercent},
                new Movie() { Title = "The Matrix Reloaded", AgeRestriction = 14, Genre = Genre.SciFi, Id = 15, IsAviable = true, Language = "EN", Length = 180, Quantity = 10, ReleaseDate = new DateTime(2003, 5, 2),Disocunt = Discount.None  },
                new Movie() { Title = "Splice", AgeRestriction = 18, Genre = Genre.SciFi, Id = 16, IsAviable = true, Language = "EN", Length = 180, Quantity = 3, ReleaseDate = new DateTime(2010, 5, 2),Disocunt = Discount.None  },
                new Movie() { Title = "Rise of the planet of the apes", AgeRestriction = 12, Genre = Genre.SciFi, Id = 17, IsAviable = true, Language = "EN", Length = 180, Quantity = 2, ReleaseDate = new DateTime(2011, 5, 2),Disocunt = Discount.None  },
                    
                
                //discounts
                new Movie() { Title ="Godfellas", AgeRestriction = 13, Genre = Genre.Action, Id = 18, IsAviable = true, Language = "EN", Length = 180, Quantity = 1, ReleaseDate = new DateTime(1990, 5, 2), Disocunt = Discount.FiftyPercent },
                new Movie() { Title ="Home Alone", AgeRestriction = 12, Genre = Genre.Comedy, Id = 19, IsAviable = true, Language = "EN", Length = 180, Quantity = 3, ReleaseDate = new DateTime(2000, 5, 2),Disocunt = Discount.TenPercent },
                new Movie() { Title ="Misery", AgeRestriction = 14, Genre = Genre.Horror, Id = 20, IsAviable = true, Language = "EN", Length = 180, Quantity = 2, ReleaseDate = new DateTime(2001, 5, 2),Disocunt = Discount.FiftyPercent},
                new Movie() { Title ="Die Hard", AgeRestriction = 12, Genre = Genre.Action, Id = 21, IsAviable = true, Language = "EN", Length = 180, Quantity = 4, ReleaseDate = new DateTime(2002, 5, 2),Disocunt = Discount.AlmostFree },
                new Movie() { Title ="Breakfast Club", AgeRestriction = 11, Genre = Genre.Comedy, Id = 22, IsAviable = true, Language = "EN", Length = 180, Quantity = 2, ReleaseDate = new DateTime(2003, 5, 2),Disocunt = Discount.FiftyPercent },
                new Movie() { Title ="Casablanca", AgeRestriction = 12, Genre = Genre.Drama, Id = 23, IsAviable = true, Language = "EN", Length = 180, Quantity = 4, ReleaseDate = new DateTime(1999, 5, 2),Disocunt = Discount.TenPercent },
                new Movie() { Title ="Rare Window", AgeRestriction = 13, Genre = Genre.Drama, Id = 24, IsAviable = true, Language = "EN", Length = 180, Quantity = 2, ReleaseDate = new DateTime(1998, 5, 2),Disocunt = Discount.FiftyPercent },
                new Movie() { Title ="Vertigo", AgeRestriction = 12, Genre = Genre.Horror, Id = 25, IsAviable = true, Language = "EN", Length = 180, Quantity = 4, ReleaseDate = new DateTime(1998, 5, 2), Disocunt = Discount.AlmostFree},


                //premiers
                new Movie() { Title ="Mulan", AgeRestriction = 12, Genre = Genre.Action, Id = 26, IsAviable = true, Language = "EN", Length = 180, Quantity = 2, ReleaseDate = new DateTime(2020, 5, 2), isapremier = true,Disocunt = Discount.None },
                new Movie() { Title ="Wonder Woman", AgeRestriction = 13, Genre = Genre.Action, Id = 27, IsAviable = true, Language = "EN", Length = 180, Quantity = 4, ReleaseDate = new DateTime(2020, 5, 2), isapremier = true ,Disocunt = Discount.None },
                new Movie() { Title ="Black Widow", AgeRestriction = 14, Genre = Genre.Action, Id = 28, IsAviable = true, Language = "EN", Length = 180, Quantity = 4, ReleaseDate = new DateTime(2020, 5, 2), isapremier = true ,Disocunt = Discount.None },
                new Movie() { Title ="Quiet Place II", AgeRestriction = 15, Genre = Genre.Horror, Id = 29, IsAviable = true, Language = "EN", Length = 180, Quantity = 4, ReleaseDate = new DateTime(2020, 5, 2), isapremier = true ,Disocunt = Discount.None },
                new Movie() { Title ="Onward", AgeRestriction = 12, Genre = Genre.Comedy, Id = 30, IsAviable = true, Language = "EN", Length = 180, Quantity = 4, ReleaseDate = new DateTime(2020, 5, 2), isapremier = true ,Disocunt = Discount.None },
                new Movie() { Title ="The Invisible Man", AgeRestriction = 15, Genre = Genre.Horror, Id = 31, IsAviable = true, Language = "EN", Length = 180, Quantity = 4, ReleaseDate = new DateTime(2020, 5, 2), isapremier = true ,Disocunt = Discount.None },
                new Movie() { Title ="Sonic", AgeRestriction = 11, Genre = Genre.SciFi, Id = 32, IsAviable = true, Language = "EN", Length = 180, Quantity = 3, ReleaseDate = new DateTime(2020, 5, 2), isapremier = true ,Disocunt = Discount.None },
                new Movie() { Title ="Vivarium", AgeRestriction = 18, Genre = Genre.Horror, Id = 33, IsAviable = true, Language = "EN", Length = 180, Quantity = 2, ReleaseDate = new DateTime(2020, 5, 2), isapremier = true ,Disocunt = Discount.None },
                new Movie() { Title ="Emma", AgeRestriction = 14, Genre = Genre.Drama, Id = 34, IsAviable = true, Language = "EN", Length = 180, Quantity = 1, ReleaseDate = new DateTime(2020, 5, 2), isapremier = true ,Disocunt = Discount.None },
                new Movie() { Title ="Candy", AgeRestriction = 14, Genre = Genre.Drama, Id = 35, IsAviable = true, Language = "EN", Length = 180, Quantity = 2, ReleaseDate = new DateTime(2020, 5, 2), isapremier = true ,Disocunt = Discount.None },
            };
        }
    }
}
