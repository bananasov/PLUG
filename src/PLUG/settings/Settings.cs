using BepInEx.Configuration;

namespace PLUG.Settings;

public class PlugSettings(ConfigFile config)
{
    public ConfigEntry<string> ServerURI =
        config.Bind<string>("Buttplug", "Server URI", "ws://127.0.0.1:12345", "The URI for the Intiface server");
}