using Terraria.ID;
using Terraria.ModLoader;

namespace UnbreakableBlockV2.Items
{
    public class ScrewdriverHead : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Screwdriver Head");
            Tooltip.SetDefault("Ouch! That is sharp!");
        }
        public override void SetDefaults()
        {
            item.width = 1;
            item.height = 1;
            item.maxStack = 1;
            item.rare = 13;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useTurn = true;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            if (UnbreakableBlockV2.serverConfig.ScrewdriverRecipe)
            {
                ModRecipe recipe = new ModRecipe(mod);
                // Recipe: Last Prism + 35 Luminite Bars
                recipe.AddIngredient(ItemID.LastPrism);
                recipe.AddIngredient(ItemID.LunarBar, 35);
                // Made At: Ancient Manipulator
                recipe.AddTile(TileID.LunarCraftingStation);
                // Makes: 1 Screwdriver Head
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}