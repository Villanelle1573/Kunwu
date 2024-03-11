using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using kunwu.Projectiles;

namespace kunwu.Items.Weapons
{
    public class Canger : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 18;
            Item.knockBack = 3f;
            Item.crit = 16;
            Item.DamageType = DamageClass.Ranged;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAmmo = AmmoID.Bullet;
            Item.noMelee = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item11;
            Item.useTime = 5;
            Item.useAnimation = 5;
            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 24f;
        }
        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            return Main.rand.NextFloat() >= 0.1f; // 10%概率不消耗子弹
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6f, -2f);
        }
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            velocity = velocity.RotatedByRandom(MathHelper.ToRadians(5));
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 20);
            recipe.AddIngredient(ItemID.Stinger, 5);
            recipe.AddTile(TileID.Benches);
            recipe.Register();
        }
    }
}
