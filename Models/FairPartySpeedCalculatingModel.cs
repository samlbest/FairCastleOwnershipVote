using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Map;
using TaleWorlds.Core;

namespace FairCastleOwnershipVote.Models
{
    public class FairPartySpeedCalculatingModel : DefaultPartySpeedCalculatingModel
    {
        public override float CalculateFinalSpeed(MobileParty mobileParty, float baseSpeed, StatExplainer explanation)
        {
            InformationManager.DisplayMessage(new InformationMessage("thing is calculating"));

            return 15;
        }

        public override float CalculatePureSpeed(MobileParty mobileParty, StatExplainer explanation, int additionalTroopOnFootCount = 0, int additionalTroopOnHorseCount = 0)
        {
            return base.CalculatePureSpeed(mobileParty, explanation, additionalTroopOnFootCount, additionalTroopOnHorseCount);
        }
    }
}
