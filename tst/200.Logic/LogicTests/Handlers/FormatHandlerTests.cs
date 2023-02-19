using DigitalFish.Lucas.Logic.Renderers.Interfaces;
using DigitalFish.Lucas.Logic.Handlers;
using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Tests.Logic.Handlers
{
    public class FormatHandlerTests
    {
        [Fact]
        public void FormatTemplate_Happy_Flow()
        {
            // Arrange
            var template = new Template("Identifier")
            {
                Content = "lorem ipsum dolor sit amet",
                Data = null
            };

            var mockFormatter = new Mock<IRenderer>(MockBehavior.Strict);

            mockFormatter
                .Setup(m => m.Render(template))
                .Returns((Template input) => input);

            var sut = new RenderHandler(new IRenderer[]
            {
                mockFormatter.Object
            });

            // Act
            var actual = sut.RenderTemplate(template);

            // Assert
            using var scope = new AssertionScope();

            actual.Should().NotBeNull();
            actual.Should().Be(template);
        }
    }
}
