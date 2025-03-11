namespace PLUG.Patches;

public static class PlayerHealthPatches
{
    internal static void Initialize()
    {
        On.PlayerHealth.Hurt += PlayerHealthOnHurt;
    }

    private static void PlayerHealthOnHurt(On.PlayerHealth.orig_Hurt orig, PlayerHealth self, int damage, bool savingGrace, int enemyIndex)
    {
        orig(self, damage, savingGrace, enemyIndex);
        
        if (damage == 0) return;
        
        Plugin.Log.LogDebug($"We got hurt for {damage} damage!");
        
        if (!Plugin.DeviceManager.IsConnected() && !Plugin.Settings.VibrateOnDamage.Value) return; // TODO: add config for enabling and timings
        
        Plugin.DeviceManager.VibrateConnectedDevicesWithDuration(damage / 100f, 1);
    }
}