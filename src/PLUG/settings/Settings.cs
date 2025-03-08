using BepInEx.Configuration;

namespace PLUG.Settings;

public class PlugSettings(ConfigFile config)
{
    public ConfigEntry<bool> MySettingsBool =
        config.Bind<bool>("SectionName", "MySettingsBool", true, "This is an example boolean setting!");
}