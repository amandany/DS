using System.Drawing;

namespace ds.test.impl.PluginsList
{
    public class Minus : IPlugin
    {
        public string PluginName { get; } = "Minus";
        public string Version { get; } = "1.0";
        public Image Image { get; } = null;
        public string Description { get; }
        public int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}