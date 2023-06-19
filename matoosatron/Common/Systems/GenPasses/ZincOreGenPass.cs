using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.Localization;
using Terraria.IO;
using Terraria.WorldBuilding;
using matoosatron.Content.Tiles;

namespace matoosatron.Common.Systems.GenPasses
{
	public class ZincOreGenPass : GenPass
	{
        public ZincOreGenPass(string name, float weight) : base(name, weight) { }

        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            progress.Message = "Generating Zinc Ore";

            int maxToSpawn = (int)(Main.maxTilesX * Main.maxTilesY * 6E-05);
            for (int i = 0; i < maxToSpawn; i++) {
                int x = WorldGen.genRand.Next(100, Main.maxTilesX - 100);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurface - 200, Main.maxTilesY - 300);

                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 5), ModContent.TileType<ZincOreTile>());
            }

        maxToSpawn = WorldGen.genRand.Next(100, 250);
        int numSpawned = 0;
        int attempts = 0;
        while (numSpawned < maxToSpawn) {
            int x = WorldGen.genRand.Next(0, Main.maxTilesX);
            int y = WorldGen.genRand.Next(0, Main.maxTilesY);

            Tile tile = Framing.GetTileSafely(x, y);
            if(tile.TileType == TileID.Stone || tile.TileType == TileID.IceBlock) {
                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 5), ModContent.TileType<ZincOreTile>());
            }
            attempts++;
            if(attempts >= 10000) {
                break;
            }
        }
        }
    }
}