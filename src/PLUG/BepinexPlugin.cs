using BepInEx;
using BepInEx.Logging;
using PLUG.Buttplug;
using PLUG.Patches;
using PLUG.Settings;

namespace PLUG;

[BepInPlugin(LCMPluginInfo.PLUGIN_GUID, LCMPluginInfo.PLUGIN_NAME, LCMPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static ManualLogSource Log = null!;
    internal static PlugSettings Settings = null!;
    internal static DeviceManager DeviceManager { get; private set; } = null!;

    private void Awake()
    {
        Log = Logger;
        Settings = new PlugSettings(Config);
        
        DeviceManager = new DeviceManager("P.L.U.G.", Settings.ServerURI.Value);
        DeviceManager.ConnectDevices();

        PlayerHealthPatches.Initialize();
        PlayerHealthGrabPatches.Initialize();
        TruckMenuAnimatedPatches.Initialize();
        PhysGrabObjectImpactDetectorPatches.Initialize(); // That is one hell of a class name, enterprise C# everyone
        
        Log.LogInfo($"Plugin {LCMPluginInfo.PLUGIN_NAME} version {LCMPluginInfo.PLUGIN_VERSION} is loaded!");
    }
}