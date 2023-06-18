using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace matoosatron.Content.Items.Place
{
	public class ZincOre : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zinc Ore");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
		public override void SetDefaults() {
			Item.width = 16;
			Item.height = 16;
			Item.useTime = 10;
			Item.useAnimation = 15;
			Item.consumable = true;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.value = Item.sellPrice(silver: 2);
			Item.rare = ItemRarityID.White;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.maxStack = 999;

			Item.createTile = ModContent.TileType<Tiles.ZincOreTile>();
		}
	}
}