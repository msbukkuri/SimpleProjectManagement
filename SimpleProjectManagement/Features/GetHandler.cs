using System.Collections.Generic;
using SimpleProjectManagement.Models;
using SimpleProjectManagement.Repositories;

namespace SimpleProjectManagement.Features
{
    public class GetHandler
    {
        private readonly IStoryListRepository _storyListRepository;

        public GetHandler(IStoryListRepository storyListRepository)
        {
            _storyListRepository = storyListRepository;
        }

        public DashboardViewModel Execute(DashboardRequestModel requestModel)
        {
            return new DashboardViewModel()
            {
                Stories = _storyListRepository.GetAll(),
                StoryModel = new Story()
            };
        }
    }

    public class DashboardViewModel
    {
        public IEnumerable<Story> Stories { get; set; }
        public Story StoryModel { get; set; }
        public DashboardViewModel()
        {
            Stories = new List<Story>();
            StoryModel = new Story();
        }
    }

    public class DashboardRequestModel { }
}