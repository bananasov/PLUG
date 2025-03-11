using System.Linq;
using Mono.Cecil.Cil;
using MonoMod.Cil;

namespace PLUG.Patches;

public static class PlayerHealthGrabPatches
{
    internal static void Initialize()
    {
        IL.PlayerHealthGrab.Update += PlayerHealthGrabOnUpdate;
    }

    private static void PlayerHealthGrabOnUpdate(ILContext ctx)
    {
        var c = new ILCursor(ctx);
        
        c.GotoNext(
            MoveType.After,
            x => x.MatchCallvirt(typeof(PlayerHealth).GetMethod("HurtOther"))
        );
        c.Emit(OpCodes.Call, typeof(PlayerHealthGrabPatches).GetMethods().FirstOrDefault(x => x.Name == "Vibrate"));
    }
    
    public static void Vibrate()
    {
        if (!Plugin.DeviceManager.IsConnected()) return;
        
        Plugin.DeviceManager.VibrateConnectedDevicesWithDuration(0.5f, 1f);
    }
}