using UnityEngine;

namespace PLUG.Patches;

public static class PhysGrabObjectImpactDetectorPatches
{
    internal static void Initialize()
    {
        On.PhysGrabObjectImpactDetector.Break += PhysGrabObjectImpactDetectorOnBreak;
    }

    private static void PhysGrabObjectImpactDetectorOnBreak(On.PhysGrabObjectImpactDetector.orig_Break orig,
        PhysGrabObjectImpactDetector self, float valueLost, Vector3 contactPoint, int breakLevel)
    {
        orig(self, valueLost, contactPoint, breakLevel);
        Plugin.Log.LogDebug($"Damaged object for {valueLost} money with level {breakLevel}");
        
        if (Plugin.DeviceManager.IsConnected())
        {
            Plugin.DeviceManager.VibrateConnectedDevicesWithDuration(1.0f, 0.1f);
        }
    }
}