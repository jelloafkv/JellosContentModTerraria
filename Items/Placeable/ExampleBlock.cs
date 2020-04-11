
using Terraria;
using Terraria.ID;
// If you are using c# 6, you can use: "using static Terraria.Localization.GameCulture;" which would mean you could just write "DisplayName.AddTranslation(German, "");"
using Terraria.Localization;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JellosContentMod.Items.Placeable
{
	public class ExampleBlock : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded block.");
			ItemID.Sets.ExtractinatorMode[item.type] = item.type;

		}

		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = TileType<Tiles.ExampleBlock>();
		}
	}
}
