using sedc.videorental.data.BaseModels;
using sedc.videorental.data.Enums;
using System;
using System.Collections.Generic;

namespace sedc.videorental.data.Models
{
    public class Movie:BaseEntity
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string Language { get; set; }
        public bool IsAviable { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; }
        public int AgeRestriction { get; set; }
        public int Quantity { get; set; }
        public bool isapremier { get; set; }

        public Discount Disocunt { get; set; }



    }
}
