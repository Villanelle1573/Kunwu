using kunwu.Core;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace kunwu.Content.Items.Weapons.Ranged
{
    public class Canger : ModItem
    {
        public override string Texture => AssetsDirectory.Ranged + Name;

        public override void SetDefaults()
        {
            Item.damage = 16;
            Item.knockBack = 4;
            Item.crit = 16;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 11f;
            Item.scale = 1.6f;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAmmo = AmmoID.Bullet;
            Item.noMelee = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item11;
            Item.useTime = 15;
            Item.useAnimation = 5;
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
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 20)
                .AddIngredient(ItemID.Cactus, 12)
                .AddIngredient(ItemID.Stinger, 8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
