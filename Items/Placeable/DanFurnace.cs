using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace kunwu.Items.Placeable
{
    public class DanFurnace : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;
        }
        public override void SetDefaults()
        {
            Item.value = Item.buyPrice(0, 0, 2, 0);
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 15;
            Item.useAnimation = 5;
            Item.consumable = true;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Blue;
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.CraftingStations.DanFurnaceTile>());
            Item.placeStyle = 0;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.CopperBar, 20)
                .AddTile(TileID.WorkBenches)
                .Register();

            CreateRecipe()
                .AddIngredient(ItemID.TinBar, 20)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
