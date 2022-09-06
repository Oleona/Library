
using System.Drawing;


namespace TestLib
{
    abstract class AbstractClass : IPlugin
    {
        private string version;
        public string Version
        {
            get
            {
                version = "Version 0";
                return version;
            }
        }
        public abstract string PluginName { get; }
        public abstract string Description { get; }

        public Image GetImage()
        {
            return TestLib.Properties.Resources.Image2;
        }

        public abstract int Run(int input1, int input2);
    }
}
