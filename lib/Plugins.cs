using System;
using System.Collections.Generic;
using System.Linq;
using ds.test.impl.PluginsList;

namespace ds.test.impl
{
    public class Plugins: IPluginFactory
    {
        public int PluginsCount => PluginsList.Count;
        public string[] GetPluginNames => PluginsList.Select(x => x.PluginName).ToArray();
        List<IPlugin> PluginsList = new List<IPlugin>()
        {
            new SumPlugin(), new Minus()
        };
        
        public IPlugin GetPlugin(string pluginName)
        {
            foreach (var plugin in PluginsList.Where(plugin => plugin.PluginName == pluginName))
            {
                return plugin;
            }

            return null;
        }
    }
}