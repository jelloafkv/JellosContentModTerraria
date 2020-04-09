using Terraria.ID;
using Terraria.ModLoader;

namespace JellosContentMod.Items
{
     public class CursedBoneMarrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cursed Bone Marrow");
            Tooltip.SetDefault("Contains the essence of a thousand souls");
        }
        
        public override void SetDefaults()
        {
            item.width = 11;
            item.height = 11;
            item.maxStack = 99;
            item.value = 00020;
            item.rare = 3;
        }
    }
}
