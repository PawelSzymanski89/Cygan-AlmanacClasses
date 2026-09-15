using HarmonyLib;

namespace AlmanacClasses.Classes.Abilities.Core;

public static class RainProof
{
    // Valheim 1.0: AddStatusEffect(nameHash, resetTime, itemLevel, skillLevel, short variant)
    [HarmonyPatch(typeof(SEMan), nameof(SEMan.AddStatusEffect), typeof(int), typeof(bool), typeof(int), typeof(float), typeof(short))]
    private static class SEMan_AddStatusEffect_Patch1
    {
        private static bool Prefix(SEMan __instance, int nameHash)
        {
            if (__instance.m_character != Player.m_localPlayer) return true;
            if (nameHash != SEMan.s_statusEffectWet) return true;
            return !PlayerManager.m_playerTalents.ContainsKey("RainProof");
        }
    }
}