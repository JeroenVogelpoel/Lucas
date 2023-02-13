using DigitalFish.Lucas.Persistence.Models;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace DigitalFish.Lucas.Logic.Handlers
{
    public class FrontMatterHandler
    {
        public const string YAMLMarker = "---";

        public Template ParseFrontMatter(Template template)
        {
            //TODO: add prope newline handling based on content, not environment
            if (template.Content.StartsWith(YAMLMarker + Environment.NewLine))
            {
                return parseYAMLFrontMatter(template);
            }

            return template;
        }

        private Template parseYAMLFrontMatter(Template template)
        {
            using var reader = new StringReader(template.Content);
            
            var deserializer = new DeserializerBuilder()
                .IgnoreUnmatchedProperties()
                .Build();

            var parser = new Parser(reader);

            parser.Consume<StreamStart>();

            var frontMatter = deserializer.Deserialize<TemplateData>(parser);

            var content = deserializer.Deserialize<string>(parser);

            template.Content = content;
            template.Data = frontMatter;

            return template;
        }
    }
}
