using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnbreakableBlockV2.Items.Placeable
{
    public class NokiaBrick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nokia Brick");
            Tooltip.SetDefault("Super tough! Not even a luminite pickaxe can break it...");
        }

        public override void SetDefaults()
        {
            item.width = 1;
            item.height = 1;
            item.maxStack = 999;
            item.rare = 13;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useTurn = true;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("NokiaBrickTile");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            // Ingredients: 5 Player Above Logic Sensors + 15 x Nebula, Solar, Stardust and Vortex fragments
            recipe.AddIngredient(ItemID.LogicSensor_Above, 5);
            recipe.AddIngredient(ItemID.FragmentNebula, 15);
            recipe.AddIngredient(ItemID.FragmentSolar, 15);
            recipe.AddIngredient(ItemID.FragmentStardust, 15);
            recipe.AddIngredient(ItemID.FragmentVortex, 15);
            // Crafted At: Heavy Work Bench
            recipe.AddTile(TileID.HeavyWorkBench);
            // Gives: 15 Nokia Bricks
            recipe.SetResult(this, 15);
            recipe.AddRecipe();
        }
    }
}