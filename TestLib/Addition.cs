

namespace TestLib
{
    class Addition : AbstractClass, IPlugin
    {
        public override string PluginName => "Addition";

        public override string Description => "Sum two numbers";

        public override int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
