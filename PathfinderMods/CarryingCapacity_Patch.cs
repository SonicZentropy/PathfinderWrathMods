using System;
using HarmonyLib;
using Kingmaker.UnitLogic;

namespace PathfinderMods
{
    [HarmonyPatch(
        typeof(EncumbranceHelper.CarryingCapacity), 
        "GetEncumbrance",
        //Specifies GetEncumberance that takes a float param instead of the other
        new Type[] { typeof(float)} 
        )]
    public class CarryingCapacity_Patch
    {
        static void Postfix(ref Encumbrance __result)
        {
            if (!Main.Enabled) return;
            __result = Encumbrance.Light;
        }
        
    }
}