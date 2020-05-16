﻿using System;
using System.Linq;
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
            }
        }

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
