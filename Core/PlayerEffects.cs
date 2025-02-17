using Terraria;
using Terraria.ModLoader;

namespace kunwu.Core

{
    public class PlayerEffects : ModPlayer
    {
        public bool topazRing; // 黄玉扳指
        public bool revitalizingDan; // 回春丹

        public override void ResetEffects()
        {
            topazRing = false;
            revitalizingDan = false;
        }
        public override void UpdateBadLifeRegen()
        {
            if (revitalizingDan)
            {
                Player.lifeRegen += 32; // 每秒恢复 16 点生命
            }
        }
    }
}
