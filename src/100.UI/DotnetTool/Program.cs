using Autofac;
using DigitalFish.Lucas.Logic.Stores.Interfaces;
using DigitalFish.Lucas.UI.DotnetTool.DI;
using Serilog;

namespace DigitalFish.Lucas.UI.DotnetTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .MinimumLevel.Verbose()
                .CreateLogger();

            var container = Registration.RegisterAll();

            Console.WriteLine("Hello, Lucas!");
        }
    }
}