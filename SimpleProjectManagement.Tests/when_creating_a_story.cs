using FubuTestingSupport;
using NUnit.Framework;
using Rhino.Mocks;
using SimpleProjectManagement.Features.Stories;
using SimpleProjectManagement.Models;
using SimpleProjectManagement.Repositories;

namespace SimpleProjectManagement.Tests
{
    [TestFixture]
    public class when_creating_a_story : InteractionContext<PostHandler>
    {
        [Test]
        public void should_insert_story()
        {
            var inputModel = new CreateStoryInputModel
                                 {
                                     Name = "Story1",
                                     Status = "Backlog",
                                     PointValue = 1
                                 };

            MockFor<IStoryListRepository>()
                .Expect(r => r.Insert(new Story
                                          {
                                              Name = inputModel.Name,
                                              Status = inputModel.Status,
                                              PointValue = inputModel.PointValue
                                          }));

            ClassUnderTest.Execute(inputModel);

            VerifyCallsFor<IStoryListRepository>();
        }
    }
}
