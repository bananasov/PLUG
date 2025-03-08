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
        
        Plugin.Log.LogInfo($"We got hurt for {damage} damage!");
    }
}