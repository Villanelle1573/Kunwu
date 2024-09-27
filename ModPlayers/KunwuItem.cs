using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using kunwu.Items.Accessories;
using kunwu.BaseExtension;

namespace kunwu.ModPlayers
{
    public class KunwuItem : GlobalItem
    {
        public override bool InstancePerEntity => true;

        public override void ModifyShootStats(Item item, Terraria.Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if (player.KunwuPlayerBuff().topazRing == true && item.useAmmo == AmmoID.Arrow)
            {
                player.GetAttackSpeed(DamageClass.Ranged) -= 0.1f;
                velocity *= 1.2f;
            }
        }
    }
}
