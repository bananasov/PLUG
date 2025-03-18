namespace PLUG.Patches;

public static class ValuableDiscoverGraphicPatches
{
    public static void Initialize()
    {
        On.ValuableDiscoverGraphic.BadSetup += ValuableDiscoverGraphicOnBadSetup;
    }

    private static void ValuableDiscoverGraphicOnBadSetup(On.ValuableDiscoverGraphic.orig_BadSetup orig, ValuableDiscoverGraphic self)
    {
        orig(self);

        if (!Plugin.DeviceManager.IsConnected()) return;
        Plugin.DeviceManager.VibrateConnectedDevicesWithDuration(1, 1);
    }
}