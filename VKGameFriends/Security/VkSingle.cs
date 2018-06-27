using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;
using NLog.Targets;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Exception;
using VkNet.Model;

namespace VKGameFriends.Security
{
    public class VkSingleton
    {
        private static readonly VkSingleton instance = new VkSingleton();

        public VkApi Api { get; private set; }

        private VkSingleton()
        {
            Api = new VkApi(InitLogger());
        }

        public static VkSingleton getInstance()
        {
            return instance;
        }

        private static ILogger InitLogger()
        {
            var consoleTarget = new ConsoleTarget
            {
                Layout = @"${date:format=HH\:mm\:ss} ${logger} ${message}"
            };

            var fileTarget = new FileTarget
            {
                Layout = @"${date:format=HH\:mm\:ss} ${logger} ${message}",
                FileName = Path.Combine( Environment.CurrentDirectory, "Log", "Log.txt"),
            };

            var config = new LoggingConfiguration();
            //config.AddTarget("console", consoleTarget);

            config.AddTarget("file",fileTarget);
            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Debug, fileTarget));
            LogManager.Configuration = config;
            return LogManager.GetLogger("VkApi");
        }
    }
}
