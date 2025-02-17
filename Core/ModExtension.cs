using kunwu.Content.Items;
using Terraria;

namespace kunwu.Core
{
    public static class ModExtension
    {
        public static PlayerEffects KunwuPlayerEffect(this Player player) => player.GetModPlayer<PlayerEffects>();

        public static KunwuItem Kunwu(this Item item) => item.GetGlobalItem<KunwuItem>();
    }
}
