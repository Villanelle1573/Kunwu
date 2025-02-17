using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using kunwu.Core;

namespace kunwu.Content.Items
{
    public class KunwuItem : GlobalItem
    {
        public override bool InstancePerEntity => true;

        public override void ModifyShootStats(Item item, Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if (player.KunwuPlayerEffect().topazRing == true && item.useAmmo == AmmoID.Arrow)
            {
                player.GetAttackSpeed(DamageClass.Ranged) -= 0.1f;
                velocity *= 1.2f;
            }
        }
    }
}
