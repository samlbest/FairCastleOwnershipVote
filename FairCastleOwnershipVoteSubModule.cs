using System;
using System.Linq;
using FairCastleOwnershipVote.Models;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace FairCastleOwnershipVote
{
    public class FairCastleOwnershipVoteSubModule : MBSubModuleBase
    {
        internal static FairCastleOwnershipVoteSubModule Current => Module.CurrentModule.SubModules.OfType<FairCastleOwnershipVoteSubModule>().FirstOrDefault();

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            try
            {
                var harmony = new Harmony(nameof(FairCastleOwnershipVoteSubModule));
                harmony.PatchAll(typeof(FairCastleOwnershipVoteSubModule).Assembly);
            }
            catch (Exception ex)
            {
                FileLog.Log($"Error on PatchAll: {ex}");
                throw;
            }
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);
            try
            { 
                AddModels(gameStarterObject as CampaignGameStarter);
            }
            catch (Exception ex)
            {
                FileLog.Log($"Error on AddModels: {ex}");
                throw;
            }
        }

     
        private void AddModels(CampaignGameStarter gameStarter)
        {
            gameStarter.AddModel(new FairPartySpeedCalculatingModel());
        }
    }
}
