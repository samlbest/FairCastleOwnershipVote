using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace FairCastleOwnershipVote
{
    public class FairCastleOwnershipVoteSubModule : MBSubModuleBase
    {
        public override void OnCampaignStart(Game game, object starterObject)
        {
            if (starterObject is CampaignGameStarter campaignGameStarter)
            {
                AddModels(campaignGameStarter);
            }

            base.OnCampaignStart(game, starterObject);
        }

        private void AddModels(CampaignGameStarter gameStarter)
        {
            gameStarter.AddModel(new FairInventoryCapacityModel());
        }
    }
}
