using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace kunwu.Items.Placeable
{
    public class RedgoldFurnace : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;
        }
        public override void SetDefaults()
        {
            Item.value = Item.buyPrice(0, 0, 50, 0);
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 15;
            Item.useAnimation = 5;
            Item.consumable = true;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Green;
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.CraftingStations.RedgoldFurnaceTile>());
            Item.placeStyle = 0;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<RedgoldBar>(), 8);
            recipe.AddIngredient(ItemID.Hellforge);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
        }
    }
}
