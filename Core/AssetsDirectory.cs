namespace kunwu.Core
{
    public static class AssetsDirectory
    {
        public const string Assets = "kunwu/Assets/";

        #region Effects部分

        public const string Buffs = Assets + "Effects/Buffs/";
        public const string Debuffs = Assets + "Effects/Debuffs/";

        #endregion


        public const string Items = Assets + "Items/";

        #region 饰品部分

        public const string Accessories = Items + "Accessories/";

        #endregion

        #region 盔甲部分

        public const string Armors = Items + "Armors/";

        public const string RedgoldMana = Armors + "RedgoldMana/";

        #endregion

        #region 丹药部分

        public const string Dan = Items + "Dan/";

        #endregion

        #region 材料部分

        public const string Material = Items + "Material/";

        #endregion

        #region 可放置物部分

        public const string Placable = Items + "Placable/";

        #endregion

        #region 武器部分

        public const string Weapons = Items + "Weapons/";

        public const string Melee = Weapons + "Melee/";
        public const string Ranged = Weapons + "Ranged/";
        public const string Mana = Weapons + "Mana/";
        public const string Minion = Weapons + "Minion/";

        #endregion

        #region 弹幕部分

        public const string Projectiles = Assets + "Projectiles/";

        #endregion

        #region 物块部分

        public const string Tiles = Assets + "Tiles/";

        // 锭
        public const string Bar = Tiles + "Bar/";

        // 工作站
        public const string Craftingstation = Tiles + "CraftingStation/";

        #endregion
    }
}
