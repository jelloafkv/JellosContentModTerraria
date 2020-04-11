
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JellosContentMod.Tiles
{
	public class ExampleBlock : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			drop = ItemType<Items.Placeable.ExampleBlock>();
			AddMapEntry(new Color(0, 200, 0));
		}

		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			r = 0f;
			g = 0.5f;
			b = 0f;
		}

		public override void ChangeWaterfallStyle(ref int style) {
			style = mod.GetWaterfallStyleSlot("ExampleWaterfallStyle");
		}
	}
}