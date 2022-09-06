

namespace TestLib
{
    class Multiplication : AbstractClass, IPlugin
    {
        public override string PluginName => "Multiplication";

        public override string Description => "Multiplication of two numbers";

        public override int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }

}
