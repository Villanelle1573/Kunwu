using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;


namespace kunwu.Tiles
{
    public class Redgoldingot : ModTile
    {
        public int ItemDrops { get; private set; }

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileSolid[Type] = false;
            Main.tileSolidTop[Type] = true;
            Main.tileNoAttach[Type] = false;
            Main.tileBlockLight[Type] = false;
            Main.tileCut[Type] = false;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 650;
            DustType = DustID.Gold;
            HitSound = SoundID.Dig;
            MineResist = 2f;
            MinPick = 65;
            ItemDrops = ModContent.ItemType<Items.Stuff.Redgoldingot>();
            AddMapEntry(new Color(250, 170, 50));

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.Width = 1;
            TileObjectData.newTile.Height = 1;
            TileObjectData.addTile(Type);
        }
        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 3 : 10;
        }
    }
}
