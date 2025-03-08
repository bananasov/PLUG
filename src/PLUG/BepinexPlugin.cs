using BepInEx;
using BepInEx.Logging;
using PLUG.Settings;


namespace PLUG;

[BepInPlugin(LCMPluginInfo.PLUGIN_GUID, LCMPluginInfo.PLUGIN_NAME, LCMPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static ManualLogSource Log = null!;
    internal static PlugSettings Settings = null!;

    private void Awake()
    {
        Log = Logger;
        Settings = new PlugSettings(Config);
        
        Log.LogInfo($"Plugin {LCMPluginInfo.PLUGIN_NAME} version {LCMPluginInfo.PLUGIN_VERSION} is loaded!");
    }
}