using BepInEx.Configuration;

namespace PLUG.Settings;

public class PlugSettings(ConfigFile config)
{
    public readonly ConfigEntry<string> ServerURI =
        config.Bind<string>("Buttplug", "Server URI", "ws://127.0.0.1:12345", "The URI for the Intiface server");
    
    public readonly ConfigEntry<bool> VibrateOnDamage = config.Bind("Buttplug", "Vibe Damage", true, "Vibrate on damage");
}