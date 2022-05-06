using BasePlugin;
using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System;

namespace DateTimePlugin
{
    public class DateTimeP : IPlugin
    {
        public static string _Id => "date-time";
        public string Id => _Id;

        public PluginOutput Execute(PluginInput input)
        {
            return new PluginOutput(DateTime.Now.ToString());
        }
    }
}
