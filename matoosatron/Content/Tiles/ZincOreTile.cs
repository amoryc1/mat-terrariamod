using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace matoosatron.Content.Tiles
{
	public class ZincOreTile : ModTile
	{
		public override void SetStaticDefaults() {
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileOreFinderPriority[Type] = 410;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 975;
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

            AddMapEntry(new Color(175, 175, 175), CreateMapEntryName());

            DustType = DustID.Tungsten;
			HitSound = SoundID.Tink;
			MineResist = 1f;
			MinPick = 55;
            ItemDrop = ModContent.ItemType<Items.Place.ZincOre>();
		}
	}
}