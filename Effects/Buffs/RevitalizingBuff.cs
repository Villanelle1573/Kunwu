using Terraria;
using Terraria.ModLoader;
using kunwu.ModPlayers;

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
            BuffPlayer modPlayer = player.GetModPlayer<BuffPlayer>();
            modPlayer.revitalizingDan = true; // 激活回血 buff
        }   
    }
}
