using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace kunwu.Items.Stuff
{
    public class Redgoldingot : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 25;
        }
        public override void SetDefaults()
        {
            Item.value = 1500;
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 15;
            Item.useAnimation = 5;
            Item.consumable = true;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Green;
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Redgoldingot>());
            Item.placeStyle = 0;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Hellstone, 2);
            recipe.AddIngredient(ItemID.GoldBar);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
        }
    }
}
