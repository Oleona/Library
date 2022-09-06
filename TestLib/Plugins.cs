using System;
using System.Linq;
using System.Reflection;

namespace TestLib
{
    public class Plugins : IPluginFactory
    {
        private static Plugins instance;
   
        private Plugins()
        { }

        public static Plugins GetInstance()
        {
            if (instance == null)
                instance = new Plugins();
            return instance;
        }
        private static Type[] GetPluginType() =>
                   (from type in Assembly.GetExecutingAssembly().GetTypes()
                    where (typeof(IPlugin).IsAssignableFrom(type) && !type.IsAbstract)
                    select type).ToArray();
        public int PluginsCount => GetPluginType().Length;

        public string[] GetPluginNames => (from type in GetPluginType() select type.Name).ToArray();

        public IPlugin GetPlugin(string pluginName)
        {var d = (GetPluginType().Where(p => p.Name == pluginName)).ToArray().FirstOrDefault() ;
                     
            foreach (var res in GetPluginNames)
            {
                if (res == pluginName)
                {
                    return (IPlugin)Activator.CreateInstance(d);
                }

            }
             return null;
        }
       
    }
}
