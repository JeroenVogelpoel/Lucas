using DigitalFish.Lucas.Logic.Stores;
using DigitalFish.Lucas.Persistence.Models;
using DigitalFish.Lucas.Persistence.Repositories.Interfaces;
using FluentAssertions;
using FluentAssertions.Execution;

namespace DigitalFish.Lucas.Tests.Logic.Stores
{
    public class TemplateStoreTests
    {
        public Dictionary<string, Template> KnownTemplates =>
            new Dictionary<string, Template>
            {
                ["first-known-template"] = new Template
                {
                    Identifier = "first-known-template",
                    OutputName = "index.html",
                    Content = "Content #1",
                    Data = "Data #1" 
                },

                ["second-known-template"] = new Template
                {
                    Identifier = "second-known-template",
                    OutputName = "second.html",
                    Content = "Content #2",
                    Data = "Data #2"
                },

                ["third-known-template"] = new Template
                {
                    Identifier = "third-known-template",
                    OutputName = "third.html",
                    Content = "Content #3",
                    Data = "Data #3"
                }
            };

        public TemplateStore SUT => new TemplateStore(
            new ITemplateRepository[]
            {
                defaultTemplateRepositoryMockBuilder().Object
            }
        );

        [Fact]
        public void Happy_Flow_List()
        {
            // Arrange

            // Act
            var actual = SUT.List();

            // Assert
            using var scope = new AssertionScope();
            actual.Should()
                .NotBeNullOrEmpty()
                .And.HaveCount(KnownTemplates.Count);
        }

        [Fact]
        public void Happy_Flow_Find()
        {
            // Arrange

            // Act
            var actual = SUT.Find(KnownTemplates.First().Key);

            // Assert
            using var scope = new AssertionScope();
            actual.Should().NotBeNull();
            actual.Identifier.Should().Be(KnownTemplates.First().Value.Identifier);
        }

        private Mock<ITemplateRepository> defaultTemplateRepositoryMockBuilder()
        {
            var output = new Mock<ITemplateRepository>(MockBehavior.Strict);

            output
                .Setup(mock => mock.List())
                .Returns(KnownTemplates.Keys);

            output
                .Setup(mock => mock.Load(It.IsIn(KnownTemplates.Keys.ToArray())))
                .Returns((string identifier) => KnownTemplates[identifier]);

            return output;
        }
    }
}
