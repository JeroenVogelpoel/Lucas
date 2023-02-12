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
                ["first-known-template"] = new Template(
                    "first-known-template",
                    "index.html",
                    "Content #1",
                    "Data #1"),

                ["second-known-template"] = new Template(
                    "second-known-template",
                    "second.html",
                    "Content #2",
                    "Data #2"),

                ["third-known-template"] = new Template(
                    "third-known-template",
                    "third.html",
                    "Content #3",
                    "Data #3"),
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
            actual.Should().NotBeNull()
                .And.Be(KnownTemplates.First().Value);
        }

        public void Happy_Flow_Format()
        {
            // Arrange

            // Act
            //var actual = SUT
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
