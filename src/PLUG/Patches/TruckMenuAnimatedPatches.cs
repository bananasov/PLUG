namespace PLUG.Patches;

public static class TruckMenuAnimatedPatches
{
    internal static void Initialize()
    {
        On.TruckMenuAnimated.BreakerTriggerRPC += OnBreakerTriggerRPC;
    }

    private static void OnBreakerTriggerRPC(On.TruckMenuAnimated.orig_BreakerTriggerRPC orig, TruckMenuAnimated self, string triggerName)
    {
        orig(self, triggerName);
        
        Plugin.Log.LogDebug($"Truck menu event {triggerName} got called!");

        if (!Plugin.DeviceManager.IsConnected()) return;
        
        switch (triggerName)
        {
            case "SpeedUp":
                Plugin.DeviceManager.VibrateConnectedDevicesWithDuration(50 / 100f, 1);
                break;
            case "SlowDown":
                Plugin.DeviceManager.VibrateConnectedDevicesWithDuration(50 / 100f, 1);
                break;
            case "Swerve":
                Plugin.DeviceManager.VibrateConnectedDevicesWithDuration(50 / 100f, 1);
                break;
            case "SkeletonHit":
                Plugin.DeviceManager.VibrateConnectedDevicesWithDuration(50 / 100f, 1);
                break;
            case "TruckPass":
                Plugin.DeviceManager.VibrateConnectedDevicesWithDuration(50 / 100f, 1);
                break;
            default:
                Plugin.Log.LogError($"Truck menu event {triggerName} has no implementation!");
                break;
        }
    }
}