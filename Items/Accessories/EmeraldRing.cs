using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace kunwu.Items.Accessories
{
    public class EmeraldRing : ModItem
    {
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.value = Item.sellPrice(0, 0, 60, 0);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetCritChance(DamageClass.Ranged) += 6f;
            player.GetAttackSpeed(DamageClass.Ranged) -= 0.08f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Emerald, 8)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
        }
    }
}
