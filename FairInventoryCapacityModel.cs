using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents;
using TaleWorlds.CampaignSystem.SandBox.GameComponents.Party;
using TaleWorlds.Core;
using TaleWorlds.Diamond;

namespace FairCastleOwnershipVote
{
    public class FairInventoryCapacityModel : DefaultInventoryCapacityModel
    {
        public override int CalculateInventoryCapacity(MobileParty mobileParty, StatExplainer explanation = null, int additionalTroops = 0, int additionalSpareMounts = 0, int additionalPackAnimals = 0, bool includeFollowers = false)
        {
            InformationManager.DisplayMessage(new InformationMessage("Hello World!"));
            return base.CalculateInventoryCapacity(mobileParty, explanation, additionalTroops, additionalSpareMounts, additionalPackAnimals, includeFollowers);
        }
    }
}
