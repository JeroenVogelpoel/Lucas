using DigitalFish.Lucas.Logic.Stores;
using DigitalFish.Lucas.Persistence.Models;
using DigitalFish.Lucas.Persistence.Repositories.Interfaces;
using FluentAssertions;
using FluentAssertions.Execution;

namespace DigitalFish.Lucas.Tests.Logic.Stores
{
    public class TemplateStoreTests
    {
        [Fact]
        public void Happy_Flow_Find()
        {
            // Arrange
            const string TemplateIdentifier = "Sample Identifier";

            var sut = new TemplateStore(
                new ITemplateRepository[]
                {
                    defaultTemplateRepositoryMockBuilder().Object
                }
            );

            // Act
            var actual = sut.Find(TemplateIdentifier);

            // Assert
            using var scope = new AssertionScope();
            actual.Identifier.Should().Be(TemplateIdentifier);
        }

        private Mock<ITemplateRepository> defaultTemplateRepositoryMockBuilder()
        {
            var output = new Mock<ITemplateRepository>(MockBehavior.Strict);

            output
                .Setup(mock => mock.Load(It.IsAny<string>()))
                .Returns((string identifier) => new Template(identifier));

            return output;
        }
    }
}
