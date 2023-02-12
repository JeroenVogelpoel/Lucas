using DigitalFish.Lucas.Logic.Formatters;
using DigitalFish.Lucas.Logic.Formatters.Interfaces;
using DigitalFish.Lucas.Logic.Handlers.Interfaces;
using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Logic.Handlers
{
    public class FormatHandler : IFormatHandler
    {
        private readonly IEnumerable<IFormatter> _formatters;

        public FormatHandler(
            IEnumerable<IFormatter> formatters)
        {
            _formatters = formatters;
        }

        /// <inheritdoc/>
        public Template FormatTemplate(Template template)
        {
            return applyFormatters(template);
        }

        private Template applyFormatters(Template template)
        {
            //TODO: Apply formatter logic here
            return _formatters
                .First()
                .Format(template);
        }
    }
}
