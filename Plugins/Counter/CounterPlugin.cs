using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;

namespace Counter
{
    public class CounterPlugin : IPlugin
    {
        public static string _Id => "counter";
        public string Id => _Id;
        public static int count;

        public PluginOutput Execute(PluginInput input)
        {
            var lastCount = count;
            return new PluginOutput((++count).ToString());
        }
    }
}
