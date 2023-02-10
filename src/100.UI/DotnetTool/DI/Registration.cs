using Autofac;

namespace DigitalFish.Lucas.UI.DotnetTool.DI
{
    internal static partial class Registration
    {
        internal static IContainer RegisterAll()
        {
            var containerBuilder = new ContainerBuilder();

            loadPersistenceDependencies(containerBuilder);
            loadLogicDependencies(containerBuilder);

            return containerBuilder.Build();
        }
    }
}
