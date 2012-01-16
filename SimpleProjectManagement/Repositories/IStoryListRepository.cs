using System.Collections.Generic;
using SimpleProjectManagement.Models;

namespace SimpleProjectManagement.Repositories
{
    public interface IStoryListRepository
    {
        IEnumerable<Story> GetAll();
        void Insert(Story story);
    }

    public class StoryListRepository : IStoryListRepository
    {
        private readonly IList<Story> _storyList = new List<Story>();

        public IEnumerable<Story> GetAll()
        {
            return _storyList;
        }

        public void Insert(Story story)
        {
            _storyList.Add(story);
        }
    }
}