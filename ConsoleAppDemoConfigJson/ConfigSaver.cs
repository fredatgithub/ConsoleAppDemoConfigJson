using System.IO;
using Newtonsoft.Json;

namespace ConsoleAppDemoConfigJson
{
  public static class ConfigSaver
  {
    public static void Save(string path, JsonAppConfig config)
    {
      var json = JsonConvert.SerializeObject(config, Formatting.Indented);
      File.WriteAllText(path, json);
    }
  }
}