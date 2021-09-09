using System;
using HarmonyLib;
using Kingmaker.Corruption;
using Kingmaker.UnitLogic;

namespace ZenMods
{
    [HarmonyPatch(
        typeof(EncumbranceHelper.CarryingCapacity), 
        "GetEncumbrance",
        //Specifies GetEncumberance that takes a float param instead of the other
        new Type[] { typeof(float)} 
        )]
    public class Patches
    {
        static void Postfix(ref Encumbrance __result)
        {
            if (!Main.Enabled) return;
            __result = Encumbrance.Light;
        }
        
    }

    [HarmonyPatch(
        typeof(CorruptionManager),
        "GetCurrentZoneGrowthValue"
    )]
    public class CorruptionGrowth_Patch
    {
        static void Postfix(ref int __result)
        {
            if (!Main.Enabled) return;
            __result = 0;
        }

    }

/*[HarmonyPatch(typeof(BlueprintsCache), "Init")]
    static class BlueprintsCache_Init_Patch
    {
        static bool loaded = false;
        static void Postfix()
        {
           if (loaded) return;
            loaded = true;

            //FileLog.Log("Getting blueprintbuff");

            var aeonDRGazeBPBuff = ResourcesLibrary.TryGetBlueprint<BlueprintBuff>("499f5b25a863e4c4dada9f683936057c");

            var elmt = (aeonDRGazeBPBuff.ComponentsArray[1]) as Kingmaker.UnitLogic.FactLogic.AddDamageResistancePhysical;
            elmt.Alignment = DamageAlignment.Lawful;

            /*FileLog.Log($"Alignment on Aeon DR Gaze Buff is now: ");
            FileLog.Log($"{elmt.Alignment}");#1#

        }
    }*/

}