using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace kunwu.Items.Material
{
    public class Flyingserpentfeather : ModItem
    {
        public override void SetDefaults()
        {
            Item.value = 450;
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Lime;
        }
    }
}
