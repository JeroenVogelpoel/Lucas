using DigitalFish.Lucas.Persistence.Models;

namespace DigitalFish.Lucas.Logic.Handlers.Interfaces
{
    public interface IFormatHandler
    {
        /// <summary>
        /// Determines the formatter(s) to be used and applies them in order.
        /// </summary>
        /// <remarks>
        /// Formatters are determined by the template data if defined,
        /// or implied by the naming of the template. The default formatter is
        /// the <see cref="Formatters.Passthru"/> formatter.
        /// </remarks>
        Template FormatTemplate(Template template);
    }
}
