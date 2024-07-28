using kunwu.Items.Placeable;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace kunwu.Items.Armors.RedgoldMana
{
    [AutoloadEquip(EquipType.Head)]
    public class RedgoldManaHelmet : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.buyPrice(0, 1, 0, 0);
            Item.rare = ItemRarityID.Orange;
            Item.defense = 6;
        }
        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Magic) += 0.06f;
            player.GetCritChance(DamageClass.Magic) += 6f;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<RedgoldManaBreastplate>()
                && legs.type == ModContent.ItemType<RedgoldManaLeggings>();
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "魔力值消耗减少12%\n无法被点燃";
            player.manaCost -= 0.12f;
            player.buffImmune[BuffID.OnFire] = true;
        }
        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawShadow = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<RedgoldBar>(8)
                .AddIngredient(ItemID.Silk, 3)
                .AddTile<Tiles.Furniture.CraftingStations.RedgoldFurnaceTile>()
                .Register();
        }
    }
}
