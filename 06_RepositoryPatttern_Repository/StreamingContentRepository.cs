using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPatttern_Repository
{
    public class StreamingContentRepository
    {
        private List<StreamingContent> _listofContent = new List<StreamingContent>();

        //Create
        public void AddContentToList(StreamingContent content)
        {
            _listofContent.Add(content);
        }
        //Read
        public List<StreamingContent> GetContentList()
        {
            return _listofContent;
        }

        //Update

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            //find the content
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            //Update the content
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.StarRating = newContent.StarRating;
                oldContent.TypeofGenre = newContent.TypeofGenre;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveContentList(string title)
        {
            StreamingContent content = GetContentByTitle(title);

            if(content == null)
            {
                return false;
            }

            int initialCount = _listofContent.Count;
            _listofContent.Remove(content);

            if (initialCount > _listofContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper Method
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _listofContent)
            {
                if(content.Title == title)
                {
                    return content;
                }
            }

            return null;
        }

    }
}
