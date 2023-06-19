using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace matoosatron.Content.Items.Accessories
{
	public class BandOfPurity : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Band of Purity");
            Tooltip.SetDefault("Slightly increases max health and critical hit rate");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
		public override void SetDefaults() {
			Item.width = 28;
			Item.height = 20;
			Item.accessory = true;
		}
        public override void UpdateAccessory(Player plr, bool hideVisual)
        {
            plr.statLifeMax2 += 20;
            plr.statDefense += 1;
            plr.GetCritChance(DamageClass.Generic) += 5;
        }

		public override void AddRecipes() {
			CreateRecipe(1)
				.AddIngredient(ItemID.LifeCrystal, 2)
				.AddIngredient(ItemID.Shackle, 1)
                .AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}