using kunwu.ModPlayers;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

namespace kunwu.BaseExtension
{
    public static class BaseExtension
    {
        public static BuffPlayer KunwuPlayerBuff(this Player player) => player.GetModPlayer<BuffPlayer>();

        public static KunwuItem Kunwu(this Item item) => item.GetGlobalItem<KunwuItem>();
    }
}
