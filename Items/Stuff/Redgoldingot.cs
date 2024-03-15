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
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useTime = 15;
            Item.useAnimation = 5;
            Item.consumable = true;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Green;
            Item.createTile = ModContent.TileType<Tiles.Redgoldingot>();
            // Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Redgoldingot>());
            Item.placeStyle = 0;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Hellstone, 2)
                .AddIngredient(ItemID.GoldBar)
                .AddTile(TileID.Furnaces)
                .Register();

            CreateRecipe()
                .AddIngredient(ItemID.Hellstone, 2)
                .AddIngredient(ItemID.PlatinumBar)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
}
