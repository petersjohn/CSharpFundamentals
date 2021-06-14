using System;
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

    /*public enum MaturityRating
    {
        G,
        PG,
        PG13,
        R,
        NC17
    }*/
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set;}
        public string Rating { get; set; }

        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeofGenre { get; set; }

        public StreamingContent() { }
        public StreamingContent(string title, string description, string maturityRating, double starRating, bool isFamilyFriendly, GenreType genre)
        {
            Title= title;
            Description = description;
            Rating = maturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeofGenre = genre;


        }
    }
}
