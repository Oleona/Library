

namespace TestLib
{
    public interface IPlugin
    {
        string PluginName { get; }
        string Version { get; }

        System.Drawing.Image GetImage();

        string Description { get; }
        int Run(int input1, int input2);
    }

}
