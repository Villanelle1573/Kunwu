using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace kunwu.Tiles.Bar
{
    public class PouriumBarTile : ModTile
    {
        public int ItemDrops { get; private set; }

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileNoAttach[Type] = false;
            Main.tileBlockLight[Type] = false;
            Main.tileCut[Type] = false;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 650;
            DustType = DustID.Gold;
            HitSound = SoundID.Dig;
            MineResist = 3f;
            MinPick = 110;

            ItemDrops = ModContent.ItemType<Items.Placeable.PouriumBar>();

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.Width = 1;
            TileObjectData.newTile.Height = 1;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(75, 160, 255), Language.GetText("金属棒"));
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 3 : 10;
        }
    }
}
