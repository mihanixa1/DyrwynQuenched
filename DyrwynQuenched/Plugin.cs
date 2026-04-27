using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace DyrwynQuenched
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGUID    = "com.dyrwyn.quenched";
        public const string PluginName    = "DyrwynQuenched";
        public const string PluginVersion = "1.0.0";

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
