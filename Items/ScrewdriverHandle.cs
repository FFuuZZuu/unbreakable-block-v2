using Terraria.ID;
using Terraria.ModLoader;

namespace UnbreakableBlockV2.Items
{
    public class ScrewdriverHandle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Screwdriver Handle");
            Tooltip.SetDefault("The handle to the ultimate pickaxe!");
        }
        public override void SetDefaults()
        {
            item.width = 1;
            item.height = 1;
            item.maxStack = 1;
            item.rare = 2;
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
                // Recipe: 15 plastic, orange dye
                recipe.AddIngredient(mod, "Plastic", 15);
                recipe.AddIngredient(ItemID.OrangeDye);
                // Made at: Anvil
                recipe.AddTile(TileID.Anvils);
                // Makes: 1 screwdriver handle
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}