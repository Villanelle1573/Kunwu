using kunwu.Items.Placeable;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace kunwu.Items.Armors.RedgoldMana
{
    [AutoloadEquip(EquipType.Legs)]
    public class RedgoldManaLeggings : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 1, silver: 50);
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
                .AddTile<Tiles.Furniture.CraftingStations.Redgoldfurnace>()
                .Register();
        }
    }
}

