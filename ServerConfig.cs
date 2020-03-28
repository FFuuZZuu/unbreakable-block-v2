using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace UnbreakableBlockV2
{
    public class ServerConfig : ModConfig
    {
        [DefaultValue(true)]
        [Label("Screwdriver Recipe")]
        [Tooltip("Should the screwdriver recipe be craftable?")]
        [ReloadRequired]
        public bool ScrewdriverRecipe { get; set; }

        public override ConfigScope Mode => ConfigScope.ServerSide;

        public override void OnLoaded()
        {
            UnbreakableBlockV2.serverConfig = this;
        }
    }
}