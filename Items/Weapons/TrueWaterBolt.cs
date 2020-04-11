
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JellosContentMod.Items.Weapons
{
	public class TrueWaterBolt : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Shoots a beam of pure H20. ");
		}

		public override void SetDefaults() {
			item.damage = 73;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can held the weapon [Important]
			item.mana = 5;
			item.rare = 10;
			item.width = 28;
			item.height = 30;
			item.useTime = 20;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 14f;
			item.useAnimation = 20;
			item.shoot = ProjectileType<Projectiles.TrueWaterBolt>();
			item.value = Item.sellPrice(gold: 12);
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WaterBolt);
			recipe.AddIngredient(ItemID.FragmentStardust, 10 );
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
