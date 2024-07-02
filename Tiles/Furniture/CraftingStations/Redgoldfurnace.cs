using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace kunwu.Tiles.Furniture.CraftingStations
{
    public class RedgoldFurnace : ModTile
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
            DustType = DustID.Stone;
            HitSound = SoundID.Dig;
            MineResist = 1f;
            MinPick = 65;

            ItemDrops = ModContent.ItemType<Items.Placeable.RedgoldFurnace>();

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.Width = 3;
            TileObjectData.newTile.Height = 3;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(250, 170, 50), Language.GetText("赤金冶炼炉"));
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
