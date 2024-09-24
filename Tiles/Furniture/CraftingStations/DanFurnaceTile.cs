using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace kunwu.Tiles.Furniture.CraftingStations
{
    public class DanFurnaceTile : ModTile
    {
        public int ItemDrops { get; private set; }

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileSolid[Type] = false;
            Main.tileSolidTop[Type] = false;
            Main.tileNoAttach[Type] = true;
            Main.tileBlockLight[Type] = false;
            Main.tileCut[Type] = false;
            DustType = DustID.Copper;
            HitSound = SoundID.Dig;
            MineResist = 1f;
            MinPick = 35;

            ItemDrops = ModContent.ItemType<Items.Placeable.DanFurnace>();

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.Height = 2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(250, 170, 50), Language.GetText("铜丹炉"));
        }
        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 3 : 10;
        }
        public override bool Slope(int i, int j)
        {
            return false;
        }
    }
}
