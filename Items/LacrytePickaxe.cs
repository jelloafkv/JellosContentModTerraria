
using JellosContentMod.Items;
using JellosContentMod.Items.Placeable;
using JellosContentMod.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JellosContentMod.Items
{
	public class LacrytePickaxe : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Able to mine hellstone.");
		}

		public override void SetDefaults() {
			item.damage = 11;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 19;
			item.useAnimation = 19;
			item.pick = 75;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes() {
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(null, "LacryteBar", 12);
			r.AddIngredient(null, "CursedBoneMarrow", 6);
			r.AddTile(TileID.Anvils);
			r.SetResult(this);
			r.AddRecipe();
		}

	}
}