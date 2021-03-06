using mjlib.Tiles;
using System.Collections.Generic;
using System.Linq;

namespace mjlib.HandCalculating.YakuList
{
    internal class Toitoi : Yaku
    {
        public override int YakuId => 26;

        public override int TenhouId => 28;

        public override string Name => "Toitoi";

        public override string Japanese => "対々和";

        public override string English => "All Triplets";

        public override int HanOpen { get; set; } = 2;

        public override int HanClosed { get; set; } = 2;

        public override bool IsYakuman => false;

        public override bool IsConditionMet(IEnumerable<TileKinds>? hand, object[]? args = null) 
            => hand?.Count(x => x.IsPon) == 4;
    }
}