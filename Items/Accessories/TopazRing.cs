using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace kunwu.Items.Accessories
{
    public class TopazRing : ModItem
    {
        public override void SetDefaults()
        {
            Item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetCritChance(DamageClass.Ranged) += 6f;
            player.GetAttackSpeed(DamageClass.Ranged) -= 0.1f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Topaz, 8)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
        }
    }
}
