using LogicAPI.Server;
using LogicWorld.Server.Saving;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using ServerOnlyMods.Server;

namespace GHXX_UltraSaveFixerItsOver300.Server
{
    public class UltraSaveFixerItsOver300 : ServerMod, IServerSideOnlyMod
    {
        protected override void Initialize()
        {
            Logger.Info("UltraSaveFixerItsOver300 mod loading...");
            IHost Host = (IHost)typeof(LogicWorld.Server.Program).GetField("Host", BindingFlags.NonPublic | BindingFlags.Static).GetValue(null);
            ISaveManager saveMgr = (ISaveManager)Host.Services.GetService(typeof(ISaveManager));
            var oldSaveTimeMs = saveMgr.MaxAllowedTimeStepMilliseconds;
            saveMgr.MaxAllowedTimeStepMilliseconds = Config.NewMaxAllowedSaveTimeMs;
            Logger.Info($"Congratulations: UltraSaveFixerItsOver300 has just increased the maximum allowed world save time from {oldSaveTimeMs}ms to {saveMgr.MaxAllowedTimeStepMilliseconds}ms. WOOP WOOP!");
        }
    }
}