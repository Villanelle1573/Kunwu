using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using kunwu.Projectiles;

namespace kunwu.Items.Weapons.Melee
{
	public class Origin : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.kunwu.hjson file.

        public override void SetDefaults()
		{
			Item.damage = 225;
			Item.DamageType = DamageClass.Melee;
			Item.crit = 16;
			Item.width = 100;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.Purple;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Bluejianqi>();
			Item.shootSpeed = 15;
		}
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
			target.AddBuff(BuffID.OnFire, 180);
			player.AddBuff(BuffID.Regeneration, 60);
        }
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddRecipeGroup(RecipeGroupID.Wood, 10)
				.AddRecipeGroup(RecipeGroupID.IronBar, 8)
				.AddIngredient(ItemID.Diamond, 3)
				.AddTile(TileID.Anvils)
				.Register();
		}
    }
}