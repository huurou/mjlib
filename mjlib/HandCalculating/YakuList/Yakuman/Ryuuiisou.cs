using mjlib.Tiles;
using System.Collections.Generic;
using System.Linq;

namespace mjlib.HandCalculating.YakuList.Yakuman
{
    internal class Ryuuiisou : Yaku
    {
        public override int YakuId => 41;

        public override int TenhouId => 43;

        public override string Name => "Ryuuiisou";

        public override string Japanese => "緑一色";

        public override string English => "All Green";

        public override int HanOpen { get; set; } = 13;

        public override int HanClosed { get; set; } = 13;

        public override bool IsYakuman => true;

        public override bool IsConditionMet(IEnumerable<TileKinds>? hand, object[]? args = null)
        {
            if (hand is null) return false;
            var green_indices = new List<int>
            {
                19, 20, 21, 23, 25, Constants.HATSU
            };
            var indices = hand.Aggregate((x, y) => x.AddRange(y));
            return indices.All(x => green_indices.Contains(x.Value));
        }
    }
}