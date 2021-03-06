using mjlib.Tiles;
using System.Collections.Generic;
using System.Linq;

namespace mjlib.HandCalculating.YakuList
{
    internal class Tanyao : Yaku
    {
        public override int YakuId => 11;
        public override int TenhouId => 8;
        public override string Name => "Tanyao";
        public override string Japanese => "断幺九";
        public override string English => "All Simples";
        public override int HanOpen { get; set; } = 1;
        public override int HanClosed { get; set; } = 1;
        public override bool IsYakuman => false;

        public override bool IsConditionMet(IEnumerable<TileKinds>? hand, object[]? args = null)
        {
            if (hand is null) return false;
            var indices = hand.Aggregate((x, y) => x.AddRange(y));
            return indices.All(x => x.IsChuchan);
        }
    }
}