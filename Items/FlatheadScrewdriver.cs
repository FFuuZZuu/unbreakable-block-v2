using Terraria.ID;
using Terraria.ModLoader;

namespace UnbreakableBlockV2.Items
{
	public class FlatheadScrewdriver : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flat-headed Screwdriver");
			Tooltip.SetDefault("Whatever needs this to mine must be really tough.");
		}
		public override void SetDefaults()
		{
			item.damage = 1;
			item.crit = 2;
			item.melee = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 3;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 13;
			item.autoReuse = true;
			item.pick = 30000;
		}

		public override void AddRecipes()
		{
			if (UnbreakableBlockV2.serverConfig.ScrewdriverRecipe)
			{
				ModRecipe recipe = new ModRecipe(mod);
				// Recipe: Screwdriver Handle + Screwdriver Head
				recipe.AddIngredient(mod, "ScrewdriverHandle");
				recipe.AddIngredient(mod, "ScrewdriverHead");
				// Made at: Tinkerers Workbench
				recipe.AddTile(TileID.TinkerersWorkbench);
				// Makes: Flat-Headed Screwdriver
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}