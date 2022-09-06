
using System;

namespace TestLib
{
    class Division : AbstractClass, IPlugin
    {
        public override string PluginName => "Division";

        public override string Description => "Integer division";

        public override int Run(int input1, int input2)
        {
            if (input2 == 0)
            {
                throw new DivideByZeroException();
            }

            else
                return input1 / input2;
        }
    }

}
