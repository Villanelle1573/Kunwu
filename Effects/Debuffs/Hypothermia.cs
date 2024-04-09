using Terraria;
using Terraria.ModLoader;

namespace kunwu.Effects.Debuffs
{
    public class Hypothermia : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
            
        }
        public override void Update(Player player, ref int buffIndex)
        {
            if (player.lifeRegen > 0)
            {
                player.lifeRegen = 0;
            }
            player.lifeRegenTime = 0;
            
            player.lifeRegen -= 32; // 让玩家每秒减少16点血
        }
        public override bool ReApply(Player player, int time, int buffIndex)
        {
            // 当玩家被重新添加buff的时候延长buff时间
            player.buffTime[buffIndex] += time;
            return true;
        }
    }
}
