using HarmonyLib;
using UnityEngine;

namespace DyrwynQuenched
{
    [HarmonyPatch(typeof(ZNetScene), "Awake")]
    internal static class ZNetScene_Awake_Patch
    {
        private static void Postfix(ZNetScene __instance)
        {
            var prefab = __instance.GetPrefab("SwordDyrnwyn");
            if (prefab == null)
            {
                Plugin.Log.LogWarning("[DyrwynQuenched] SwordDyrwyn prefab not found in ZNetScene.");
                return;
            }

            foreach (var ps in prefab.GetComponentsInChildren<ParticleSystem>(true))
            {
                var renderer = ps.GetComponent<ParticleSystemRenderer>();
                if (renderer != null)
                    renderer.enabled = false;

                var emission = ps.emission;
                emission.enabled = false;
                ps.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }

            Plugin.Log.LogInfo("[DyrwynQuenched] Fire particles quenched.");
        }
    }
}
