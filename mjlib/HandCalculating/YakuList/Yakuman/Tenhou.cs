using mjlib.Tiles;
using System.Collections.Generic;

namespace mjlib.HandCalculating.YakuList.Yakuman
{
    internal class Tenhou : Yaku
    {
        public override int YakuId => 50;

        public override int TenhouId => 37;

        public override string Name => "Tenhou";

        public override string Japanese => "天和";

        public override string English => "Heavenly Hand";

        public override int HanOpen { get; set; } = 13;

        public override int HanClosed { get; set; } = 13;

        public override bool IsYakuman => true;

        public override bool IsConditionMet(IEnumerable<TileKinds>? hand, object[]? args = null) => true;
    }
}