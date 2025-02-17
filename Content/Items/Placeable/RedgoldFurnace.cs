using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using kunwu.Core;
using kunwu.Content.Tiles.CraftingStations;

namespace kunwu.Content.Items.Placeable
{
    public class RedgoldFurnace : ModItem
    {
        public override string Texture => AssetsDirectory.Placeable + Name;

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
            Item.DefaultToPlaceableTile(ModContent.TileType<RedgoldFurnaceTile>());
            Item.placeStyle = 0;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<RedgoldBar>(), 8)
                .AddIngredient(ItemID.Hellforge)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
}
