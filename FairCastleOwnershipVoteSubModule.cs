using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace FairCastleOwnershipVote
{
    public class FairCastleOwnershipVoteSubModule : MBSubModuleBase
    {
  
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);

            AddModels(gameStarterObject as CampaignGameStarter);
        }

     
        private void AddModels(CampaignGameStarter gameStarter)
        {
            gameStarter.AddModel(new FairPartySpeedCalculatingModel());
        }
    }
}
