using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Security.AccessControl;
using Terraria.GameContent.Generation;
using JellosContentMod.Tiles;

namespace JellosContentMod
{
    public class jcmworld : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if(shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("JCM Ore Generation", OreGeneration));
            }

        }


        private void OreGeneration(GenerationProgress progress)
        {
            progress.Message = "Generating Modded Ores";
            for(var i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); i++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceHigh, Main.maxTilesY);

                WorldGen.TileRunner(
                    x,
                    y,
                    (double)WorldGen.genRand.Next(3, 6),
                    WorldGen.genRand.Next(2, 6),
                    mod.TileType("Lacryte"),
                    false,
                    0f,
                    0f,
                    false,
                    true
                );
            }
        }
    }
}
