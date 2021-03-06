using mjlib.Tiles;
using System.Collections.Generic;

namespace mjlib.HandCalculating.YakuList.Yakuman
{
    internal class RenhouYakuman : Yaku
    {
        public override int YakuId => 52;

        public override int TenhouId => -1;

        public override string Name => "Renhou";

        public override string Japanese => "人和";

        public override string English => "Hand of Man";

        public override int HanOpen { get; set; } = 13;

        public override int HanClosed { get; set; } = 13;

        public override bool IsYakuman => true;

        public override bool IsConditionMet(IEnumerable<TileKinds>? hand, object[]? args = null) => true;
    }
}