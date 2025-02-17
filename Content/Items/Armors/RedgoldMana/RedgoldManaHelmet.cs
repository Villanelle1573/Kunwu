using kunwu.Content.Items.Placeable;
using kunwu.Content.Tiles.CraftingStations;
using kunwu.Core;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace kunwu.Content.Items.Armors.RedgoldMana
{
    [AutoloadEquip(EquipType.Head)]
    public class RedgoldManaHelmet : ModItem
    {
        public override string Texture => AssetsDirectory.RedgoldMana + Name;

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
                .AddTile<RedgoldFurnaceTile>()
                .Register();
        }
    }

    [AutoloadEquip(EquipType.Body)]
    public class RedgoldManaBreastplate : ModItem
    {
        public override string Texture => AssetsDirectory.RedgoldMana + Name;

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.rare = ItemRarityID.Orange;
            Item.defense = 8;
        }
        public override void UpdateEquip(Player player)
        {
            player.statManaMax2 += 80;
            player.GetCritChance(DamageClass.Magic) += 4f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<RedgoldBar>(20)
                .AddIngredient(ItemID.Silk, 8)
                .AddTile<RedgoldFurnaceTile>()
                .Register();
        }
    }

    [AutoloadEquip(EquipType.Legs)]
    public class RedgoldManaLeggings : ModItem
    {
        public override string Texture => AssetsDirectory.RedgoldMana + Name;

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.buyPrice(0, 1, 50, 0);
            Item.rare = ItemRarityID.Orange;
            Item.defense = 7;
        }
        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Magic) += 0.06f;
            player.moveSpeed += 0.08f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<RedgoldBar>(12)
                .AddIngredient(ItemID.Silk, 5)
                .AddTile<RedgoldFurnaceTile>()
                .Register();
        }
    }
}
