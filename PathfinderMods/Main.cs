using System.Reflection;
using UnityEngine;
using UnityModManagerNet;
using UnityEngine.UI;
using HarmonyLib;

namespace AeonDRGazeFix
{
    static class Main
    {
        public static bool Enabled;
       

        static bool Load(UnityModManager.ModEntry modEntry)
        {
       
            modEntry.OnToggle = OnToggle;
            //modEntry.OnGUI = OnGUI;
            //modEntry.OnSaveGUI = OnSaveGUI;
            var harmony = new Harmony(modEntry.Info.Id);
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            return true;
        }

        static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            Enabled = value;
            return true;
        }

        /*static void OnGUI(UnityModManager.ModEntry modEntry)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label("MyFloatOption", GUILayout.ExpandWidth(false));
            GUILayout.Space(10);
            Settings.MyFloatOption = GUILayout.HorizontalSlider(Settings.MyFloatOption, 1f, 10f, GUILayout.Width(300f));
            GUILayout.Label($" {Settings.MyFloatOption:p0}", GUILayout.ExpandWidth(false));
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("MyBoolOption", GUILayout.ExpandWidth(false));
            GUILayout.Space(10);
            Settings.MyBoolOption = GUILayout.Toggle(Settings.MyBoolOption, $" {Settings.MyBoolOption}", GUILayout.ExpandWidth(false));
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUILayout.Label("MyTextOption", GUILayout.ExpandWidth(false));
            GUILayout.Space(10);
            Settings.MyTextOption = GUILayout.TextField(Settings.MyTextOption, GUILayout.Width(300f));
            GUILayout.EndHorizontal();
        }

        static void OnSaveGUI(UnityModManager.ModEntry modEntry)
        {
            Settings.Save(modEntry);
        }*/
    }
}