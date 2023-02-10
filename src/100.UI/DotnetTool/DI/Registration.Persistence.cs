using Autofac;
using DigitalFish.Lucas.Persistence.Repositories;
using DigitalFish.Lucas.Persistence.Repositories.Interfaces;

namespace DigitalFish.Lucas.UI.DotnetTool.DI
{
    internal static partial class Registration
    {
        private static void loadPersistenceDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<FileTemplateRepository>()
                .As<ITemplateRepository>();
        }
    }
}
