

namespace TestLib
{
    class Subtraction : AbstractClass, IPlugin
    {
        public override string PluginName => "Subtraction";

        public override string Description => "Subtract the second number from the first";

        public override int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }

}
