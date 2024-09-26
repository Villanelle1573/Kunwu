using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using kunwu.BaseExtension;

namespace kunwu.Items.Accessories
{
    public class TopazRing : ModItem
    {
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.value = Item.buyPrice(0, 0, 20, 0);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.KunwuPlayerBuff().topazRing = true;
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
