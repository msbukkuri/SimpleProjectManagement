using System.Collections;
using System.Collections.Generic;
using FubuTestingSupport;
using NUnit.Framework;
using Rhino.Mocks;
using SimpleProjectManagement.Features;
using SimpleProjectManagement.Models;
using SimpleProjectManagement.Repositories;

namespace SimpleProjectManagement.Tests
{
    [TestFixture]
    public class when_displaying_the_dashboard : InteractionContext<GetHandler>
    {
        [Test]
        public void should_display_stories()
        {
            var story = new Story
                            {
                                Id = "1234"
                            };

            MockFor<IStoryListRepository>()
                .Expect(r => r.GetAll())
                .Return(new List<Story> { story });

            IEnumerable<Story> stories = ClassUnderTest.
                Execute(new DashboardRequestModel())
                .Stories;

            ClassUnderTest.
                Execute(new DashboardRequestModel())
                .Stories
                .ShouldContain(s => s.Id.Equals(story.Id));

            VerifyCallsFor<IStoryListRepository>();
        }
    }
}