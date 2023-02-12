using DigitalFish.Lucas.Logic.Formatters;
using DigitalFish.Lucas.Logic.Formatters.Interfaces;
using DigitalFish.Lucas.Logic.Handlers;
using DigitalFish.Lucas.Persistence.Models;
using FluentAssertions;
using FluentAssertions.Execution;

namespace DigitalFish.Lucas.Tests.Logic.Handlers
{
    public class FormatHandlerTests
    {
        [Fact]
        public void FormatTemplate_Happy_Flow()
        {
            // Arrange
            var template = new Template
            {
                Identifier = "Identifier",
                OutputName = "index.html",
                Content = "lorem ipsum dolor sit amet",
                Data = null
            };

            var mockFormatter = new Mock<IFormatter>(MockBehavior.Strict);

            mockFormatter
                .Setup(m => m.Format(template))
                .Returns((Template input) => input);

            var sut = new FormatHandler(new IFormatter[]
            {
                mockFormatter.Object
            });

            // Act
            var actual = sut.FormatTemplate(template);

            // Assert
            using var scope = new AssertionScope();

            actual.Should().NotBeNull();
            actual.Should().Be(template);
        }
    }
}
