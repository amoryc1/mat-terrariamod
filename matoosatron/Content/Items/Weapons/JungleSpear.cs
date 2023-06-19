using matoosatron.Content.Projectiles;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace matoosatron.Content.Items.Weapons
{
    public class JungleSpear : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Jungle Spear");
			Tooltip.SetDefault("50% chance to poison enemy for 5 seconds\nPoisons enemy for 8 seconds on critical hit");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			ItemID.Sets.SkipsInitialUseSound[Item.type] = true;
			ItemID.Sets.Spears[Item.type] = true;
		}

		public override void SetDefaults() {
			// Common Properties
			Item.rare = ItemRarityID.Blue; 
			Item.value = Item.sellPrice(silver: 8, copper: 80); 
			// Use Properties
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 24;
			Item.useTime = 24;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;

			// Weapon Properties
			Item.damage = 19;
			Item.knockBack = 3.5f;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.noMelee = true;

			Item.shootSpeed = 3.7f; // The speed of the projectile measured in pixels per frame.
			Item.shoot = ModContent.ProjectileType<JungleSpearProj>(); // The projectile that is fired from this weapon
		}

		public override bool CanUseItem(Player player) {
			// Ensures no more than one spear can be thrown out, use this when using autoReuse
			return player.ownedProjectileCounts[Item.shoot] < 1;
		}

		public override bool? UseItem(Player player) {
			if (!Main.dedServ && Item.UseSound.HasValue) {
				SoundEngine.PlaySound(Item.UseSound.Value, player.Center);
			}

			return null;
		}
    
		public override void AddRecipes() {
			CreateRecipe(1)
				.AddIngredient(ItemID.JungleSpores, 8)
				.AddIngredient(ItemID.RichMahogany, 12)
                .AddTile(TileID.Anvils)
				.Register();
		}
	}
}