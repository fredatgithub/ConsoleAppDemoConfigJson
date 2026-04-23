using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleAppDemoConfigJson
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      var config = ConfigLoader.Load("application.config.json");

      string apiUrl = config.Settings["ApiUrl"];
      Display($"API URL: {apiUrl}");
      string timeout = config.Settings["Timeout"];
      Display($"Timeout: {timeout} seconds");
      string mode = config.Settings["Mode"];
      Display($"Mode: {mode}");
      Display("");
      Display("Updating configuration...");
      Display("");
      Display("New configuration values:");
      Display($"API URL: https://api.exemplepreprod.com");
      Display($"Timeout: 60 seconds");
      Display($"Mode: PreProduction");
      Display("");
      config = new JsonAppConfig
      {
        Settings = new Dictionary<string, string>
        {
          { "ApiUrl", "https://api.exemplepreprod.com" },
          { "Timeout", "60" },
          { "Mode", "PreProduction" }
        }
      };

      ConfigSaver.Save("application.config.json", config);
      Display("Configuration saved to application.config.json");
      Display("New configuration content:");
      string configContent = File.ReadAllText("application.config.json");
      Display(configContent);
      Display("");
      Display("Press any key to exit...");
      Console.ReadKey();

    }
  }
}
