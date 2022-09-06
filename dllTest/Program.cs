using System;
using TestLib;

namespace dllTest
{
    class Program
    {
      public static void Main()
        {
            Console.WriteLine("Start In Program");
            Plugins myFactory = Plugins.GetInstance();
            var testDiv = myFactory.GetPlugin("Division");           
            Console.WriteLine($"description: {testDiv.Description},  PluginName: {testDiv.PluginName},  Version: {testDiv.Version},  image: {testDiv.GetImage()}");
           
            Console.WriteLine($" result of division 3 and 5 is {testDiv.Run(3, 5)}");

            var plugName = myFactory.GetPluginNames;
            Console.Write("All possible operations: ");
            foreach (var name in plugName)
            {
                Console.Write($"{name}  ");
            }

            var count = myFactory.PluginsCount;
            Console.WriteLine("\nCount of possible operations: " + count);
            Console.WriteLine("End In Program");

        }
    }
}
