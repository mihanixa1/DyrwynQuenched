using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace DyrnwynQuenched
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGUID    = "com.dyrnwyn.quenched";
        public const string PluginName    = "DyrnwynQuenched";
        public const string PluginVersion = "1.0.1";

        internal static ManualLogSource Log;

        private void Awake()
        {
            Log = Logger;
            Log.LogInfo($"{PluginName} v{PluginVersion} loading…");

            var harmony = new Harmony(PluginGUID);
            harmony.PatchAll();

            Log.LogInfo($"{PluginName} patches applied.");
        }
    }
}
