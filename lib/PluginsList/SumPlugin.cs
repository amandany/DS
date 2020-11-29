using System.Drawing;

namespace ds.test.impl.PluginsList
{
    public class SumPlugin : IPlugin
    {
        public string PluginName { get; } = "Sum";
        public string Version { get; }
        public Image Image { get; }
        public string Description { get; }
        public int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}