using Terraria;
using Terraria.ModLoader;

namespace kunwu.Effects.Buffs
{
    public class RevitalizingBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            Main.buffNoTimeDisplay[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            RevitalizingBuffPlayer modPlayer = player.GetModPlayer<RevitalizingBuffPlayer>();
            modPlayer.revitalizingBuff = true; // 激活回血 buff
        }   
    }
    public class RevitalizingBuffPlayer : ModPlayer
    {
        public bool revitalizingBuff;

        public override void ResetEffects()
        {
            revitalizingBuff = false; // 每次更新重置 buff 状态
        }
        public override void UpdateBadLifeRegen()
        {
            if (revitalizingBuff)
            {
                Player.lifeRegen += 40; // 每秒恢复 20 点生命
            }
        }
    }
}
