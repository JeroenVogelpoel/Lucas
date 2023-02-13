using DigitalFish.Lucas.Logic.Handlers;
using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Tests.Logic.Handlers
{
    public class FrontMatterHandlerTests
    {
        public const string TemplateIdentifier = nameof(TemplateIdentifier);
        public const string TemplateContent = nameof(TemplateContent);
        public const string TemplateTarget = nameof(TemplateTarget);

        [Fact]
        public void ParseFrontMatter_Happy_Flow()
        {
            // Arrange
            var template = new Template(TemplateIdentifier)
            {
                Content = @$"---
# Sample
  Target: {TemplateTarget} # comment

# multi?
# line?
# comment?
---
{TemplateContent}
"
            };

            var sut = new FrontMatterHandler();

            // Act
            var actual = sut.ParseFrontMatter(template);

            // Assert
            using var scope = new AssertionScope();
            actual.Should().NotBeNull();
            actual.Identifier.Should().Be(TemplateIdentifier);
            actual.Content.Should().Be(TemplateContent);
            actual.Data.Should().NotBeNull();
            actual.Data.Target.Should().Be(TemplateTarget);
        }

        [Fact]
        public void ParseFrontMatter_No_Front_Matter()
        {
            // Arrange
            var template = new Template(TemplateIdentifier)
            {
                Content = TemplateContent
            };

            var sut = new FrontMatterHandler();

            // Act
            var actual = sut.ParseFrontMatter(template);

            // Assert
            using var scope = new AssertionScope();
            actual.Should().NotBeNull();
            actual.Identifier.Should().Be(TemplateIdentifier);
            actual.Content.Should().Be(TemplateContent);
            actual.Data.Should().BeNull();
        }
    }
}
