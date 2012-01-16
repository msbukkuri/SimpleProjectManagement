using FubuValidation;
using SimpleProjectManagement.Models;
using SimpleProjectManagement.Repositories;
using FubuMVC.Core.Continuations;

namespace SimpleProjectManagement.Features.Stories
{
    public class PostHandler
    {
        private readonly IStoryListRepository _repository;

        public PostHandler(IStoryListRepository repository)
        {
            _repository = repository;
        }

        public FubuContinuation Execute(CreateStoryInputModel inputModel)
        {
            //var response = new JsonResponse { Success = true };
            var story = new Story()
            {
                Name = inputModel.Name,
                Status = inputModel.Status,
                PointValue = inputModel.PointValue
            };

            _repository.Insert(story);

            return FubuContinuation.RedirectTo(new DashboardViewModel());
        }
    }

    public class CreateStoryInputModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public int PointValue { get; set; }
    }
}