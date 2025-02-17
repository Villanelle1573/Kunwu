using kunwu.Core;
using Terraria;
using Terraria.ModLoader;

namespace kunwu.Content.Effects.Buffs
{
    public class RevitalizingBuff : ModBuff
    {
        public override string Texture => AssetsDirectory.Buffs + Name;

        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            Main.buffNoTimeDisplay[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            PlayerEffects modPlayer = player.GetModPlayer<PlayerEffects>();
            modPlayer.revitalizingDan = true; // 激活回血 buff
        }
    }
}
