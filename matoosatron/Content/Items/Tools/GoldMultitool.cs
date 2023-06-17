using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace matoosatron.Content.Items.Tools
{
	public class GoldMultitool : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Golden Multitool");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
		public override void SetDefaults() {
			Item.damage = 6;
			Item.DamageType = DamageClass.Melee;
			Item.width = 36;
			Item.height = 32;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 2;
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;

			Item.pick = 55;
			Item.axe = 11; // for some reason, the axe power is multiplied by 5 so you have to divide the actual axe power by 5
			Item.hammer = 55;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.GoldBar, 6)
				.AddIngredient(ItemID.GoldAxe)
                .AddIngredient(ItemID.GoldPickaxe)
                .AddIngredient(ItemID.GoldHammer)
				.Register();
		}
	}
}