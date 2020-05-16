using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Party;

namespace FairCastleOwnershipVote.Patches
{
    [HarmonyPatch(typeof(DefaultPartySizeLimitModel), "CalculateMobilePartyMemberSizeLimit")]
    public class TestPatch
    {
        static void Postfix(MobileParty party, StatExplainer explanation, ref int __result)
        {
            //if (party.IsCaravan && party.Party?.Owner != null && party.Party.Owner == Hero.MainHero)
            //{
            //    __result = 15;
            //}
        }
    }
}
