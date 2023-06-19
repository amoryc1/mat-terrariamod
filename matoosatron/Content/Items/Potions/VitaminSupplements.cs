using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace matoosatron.Content.Items.Potions
{
	public class VitaminSupplements : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vitamin Supplements");
            Tooltip.SetDefault("'nomnomnom'\nMinor improvements to all stats");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 20;
        }
		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 24;

			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.sellPrice(silver:2);
			Item.UseSound = SoundID.Item3;
			Item.maxStack = 30;
			Item.consumable = true;

			Item.buffType = BuffID.WellFed;
			Item.buffTime = 180*60;
		}

		public override void AddRecipes() {
			CreateRecipe(1)
				.AddIngredient(ItemID.BottledWater, 1)
				.AddIngredient(ModContent.ItemType<Place.ZincBar>(), 8)
                .AddTile(TileID.Bottles)
				.Register();
		}
	}
}