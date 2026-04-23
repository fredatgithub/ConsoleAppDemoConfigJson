using System.IO;
using Newtonsoft.Json;

namespace ConsoleAppDemoConfigJson
{
  public static class ConfigLoader
  {
    public static JsonAppConfig Load(string path)
    {
      var json = File.ReadAllText(path);
      return JsonConvert.DeserializeObject<JsonAppConfig>(json);
    }
  }
}