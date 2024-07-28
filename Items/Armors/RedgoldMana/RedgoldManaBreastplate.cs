using kunwu.Items.Placeable;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace kunwu.Items.Armors.RedgoldMana
{
    [AutoloadEquip(EquipType.Body)]
    public class RedgoldManaBreastplate : ModItem
    {
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
                .AddTile<Tiles.Furniture.CraftingStations.RedgoldFurnaceTile>()
                .Register();
        }
    }
}
