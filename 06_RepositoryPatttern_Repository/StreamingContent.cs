﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPatttern_Repository
{
    //Plain Old C# Object --POCO//

    public enum GenreType
    {
        Horror = 1,
        RomCom,
        SciFi,
        Documentary,
        Bromance,
        Drama,
        Action
    }
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set;}
        public string MaturityRating { get; set; }

        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeofGenre { get; set; }

        public StreamingContent() { }
        public StreamingContent(string title, string description, string maturityRating, double starRating, bool isFamilyFriendly, GenreType genre)
        {
            Title= title;
            Description = description;
            MaturityRating = maturityRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeofGenre = genre;


        }
    }
}
