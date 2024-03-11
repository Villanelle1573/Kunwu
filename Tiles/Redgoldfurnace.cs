using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace kunwu.Tiles
{
    public class Redgoldfurnace : ModTile
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
            ItemDrops = ModContent.ItemType<Items.Stuff.Redgoldfurnace>();
            AddMapEntry(new Color(250, 170, 50));

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.newTile.Width = 3;
            TileObjectData.newTile.Height = 3;
            TileObjectData.addTile(Type);
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
