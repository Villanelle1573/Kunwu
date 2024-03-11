using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace kunwu.Items.Stuff
{
    public class Chacoal : ModItem
    {
        public override void SetDefaults()
        {
            Item.value = 100;
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 5;
            Item.useAnimation = 5;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.White;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddRecipeGroup(RecipeGroupID.Wood, 2);
            recipe.AddTile(TileID.Furnaces);
            recipe.Register();
        }
    }
}
