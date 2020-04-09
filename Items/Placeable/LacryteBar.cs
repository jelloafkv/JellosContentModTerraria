using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JellosContentMod.Items.Placeable
{
      class LacryteBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[item.type] = 62; // influences the inventory sort order. 59 is PlatinumBar, higher is more valuable.
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 750;
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = TileType<Tiles.LacryteBarTile>();
			item.placeStyle = 0;
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(null, "LacryteOre", 3);
			r.AddTile(TileID.Furnaces);
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}