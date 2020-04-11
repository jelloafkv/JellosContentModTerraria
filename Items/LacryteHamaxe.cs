
using JellosContentMod.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JellosContentMod.Items
{
	public class LacryteHamaxe : ModItem
	{
		public override void SetDefaults() {
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.axe = 20;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.hammer = 60;      //How much hammer power the weapon has
			item.useStyle = 1;
			item.knockBack = 2;
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
