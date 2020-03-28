using System;
using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

namespace UnbreakableBlockV2
{
    public static class Config
    {
        public static bool screwdriverRecipe = true;

        // Path: "Terraria/ModLoader/Mod Configs/Unbreakable Block V2.json"
        static string configPath = Path.Combine(Main.SavePath, "Mod Configs", "Unbreakable Block V2.json");

        static Preferences Configuration = new Preferences(configPath);

        public static void Load()
        {
            bool success = ReadConfig();

            if (!success)
            {
                CreateConfig();
            }
        }

        static bool ReadConfig()
        {
            if(Configuration.Load())
            {
                Configuration.Get("screwdriverRecipe", ref screwdriverRecipe);
                return true;
            }
            return false;
        }

        private static void CreateConfig()
        {
            Configuration.Clear();
            Configuration.Put("screwdriverRecipe", screwdriverRecipe);
            Configuration.Save();
        }
    }
}