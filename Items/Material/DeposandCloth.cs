using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace kunwu.Items.Material
{
    public class DeposandCloth : ModItem
    {
        public override void SetDefaults()
        {
            Item.value = Item.buyPrice(0, 0, 1, 50);
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Blue;
        }
    }
}
