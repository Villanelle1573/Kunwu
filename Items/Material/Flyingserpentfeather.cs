﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace kunwu.Items.Material
{
    public class FlyingserpentFeather : ModItem
    {
        public override void SetDefaults()
        {
            Item.value = Item.buyPrice(0, 0, 2, 0);
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Lime;
        }
    }
}
