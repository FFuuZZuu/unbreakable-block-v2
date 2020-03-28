using Terraria.ID;
using Terraria.ModLoader;

namespace UnbreakableBlockV2.Items
{
    public class Plastic : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plastic");
            Tooltip.SetDefault("A very versitile, hard substance");
        }

        public override void SetDefaults()
        {
            item.width = 1;
            item.height = 1;
            item.maxStack = 999;
            item.rare = 2; // Orange
            item.value = 5;
        }

        public override void AddRecipes()
        {
            if (UnbreakableBlockV2.serverConfig.ScrewdriverRecipe)
            if (UnbreakableBlockV2.serverConfig.ScrewdriverRecipe)
            {
                ModRecipe recipe = new ModRecipe(mod);
                // Recipe: 20 Gel + 10 Bees Wax
                recipe.AddIngredient(ItemID.Gel, 20);
                recipe.AddIngredient(ItemID.BeeWax, 10);
                // Made at: Furnace
                recipe.AddTile(TileID.Furnaces);
                // Makes: 20 Plastic
                recipe.SetResult(this, 20);
                recipe.AddRecipe();
            }
        }
    }
}