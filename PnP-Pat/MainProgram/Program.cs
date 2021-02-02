using System;
using System.IO;
using System.Reflection;
using Ventus;

namespace MainProgram
{
    class Program
    {
        const string TestString = " This is a test    With words  ";

        static void Main()
        {
            Console.WriteLine("Test string: «" + TestString + "»");
            Console.WriteLine();
            foreach (var record in RegisteredPlugins())
                TestPlugin(record);
        }

        private static void TestPlugin(PluginRecord record)
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var fullPath = Path.Combine(basePath, "plugins", record.Assembly);
            var assembly = Assembly.LoadFile(fullPath);
            var plugin = assembly.CreateInstance(record.TypeName) as IPlugin;
            if (plugin != null)
            {
                Console.WriteLine("Testing {0} plugin.", record.Name);
                foreach (var mode in plugin.Modes)
                {
                    var s = plugin.Transform(TestString, mode);
                    Console.WriteLine("Mode: {0}", mode);
                    Console.WriteLine("«" + s + "»");
                }
            }
            Console.WriteLine();
        }

        private static PluginRecord[] RegisteredPlugins()
        {
            return new[]
            {
                new PluginRecord {Name = "Case", Assembly = "CasePlugin.dll", TypeName = "Ventus.CasePlugin"},
                new PluginRecord {Name = "Spacing", Assembly = "SpacingPlugin.dll", TypeName = "Ventus.SpacingPlugin"},
                new PluginRecord {Name = "Trim", Assembly = "TrimPlugin.dll", TypeName = "Ventus.TrimPlugin"},
            };
        }
    }
}
