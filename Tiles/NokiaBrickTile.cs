using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace UnbreakableBlockV2.Tiles
{
    public class NokiaBrickTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            drop = mod.ItemType("NokiaBrick");

            AddMapEntry(new Color(79, 79, 79));

            minPick = 30000;

        }
    }
}