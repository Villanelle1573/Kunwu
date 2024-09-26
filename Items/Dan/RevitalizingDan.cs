using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace kunwu.Items.Dan
{
    public class RevitalizingDan : ModItem
    {
        public override void SetDefaults()
        { 
            Item.width = 16;
            Item.height = 16;
            Item.rare = ItemRarityID.Green;
            Item.value = Item.buyPrice(0, 0, 0, 80);
            Item.maxStack = 9999;

            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.consumable = true;
            Item.UseSound = SoundID.Item2;
            Item.buffType = ModContent.BuffType<Effects.Buffs.RevitalizingBuff>(); // 回复血量Buff
            Item.buffTime = 300; // 持续300 / 60 = 5秒
        }
    }
}
