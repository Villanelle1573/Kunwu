using Terraria;
using Terraria.ModLoader;

namespace kunwu.ModPlayers
{
    public class BuffPlayer : ModPlayer
    {
        public bool topazRing; // 黄玉扳指
        public bool revitalizingBuff; // 回春丹

        public override void ResetEffects()
        {
            topazRing = false;
            revitalizingBuff = false;
        }
        public override void UpdateBadLifeRegen()
        {
            if (revitalizingBuff)
            {
                Player.lifeRegen += 32; // 每秒恢复 16 点生命
            }
        }
    }
}
