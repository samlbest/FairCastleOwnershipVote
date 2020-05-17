using System;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Election;

namespace FairCastleOwnershipVote.Patches
{
    [HarmonyPatch(typeof(SettlementClaimantDecision), "CalculateMeritOfOutcome")]
    public class SettlementClaimantDecision_CalculateMeritOfOutcomePatch
    {
        static void PostFix(DecisionOutcome candidateOutcome, ref float __result)
        {
            var clanAsDecisionOutcome = AccessTools.TypeByName("TaleWorlds.CampaignSystem.Election.SettlementClaimantDecision.ClanAsDecisionOutcome");
            var clan = (Clan)clanAsDecisionOutcome.GetProperty("Clan").GetValue(candidateOutcome);
            if (clan == Clan.PlayerClan)
            {
                __result *= 2;
            }
        }
    }
}
