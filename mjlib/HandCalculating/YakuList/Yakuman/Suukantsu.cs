using mjlib.Tiles;
using System.Collections.Generic;
using System.Linq;

namespace mjlib.HandCalculating.YakuList.Yakuman
{
    internal class Suukantsu : Yaku
    {
        public override int YakuId => 42;

        public override int TenhouId => 51;

        public override string Name => "Suukantsu";

        public override string Japanese => "四槓子";

        public override string English => "Four Kans";

        public override int HanOpen { get; set; } = 13;

        public override int HanClosed { get; set; } = 13;

        public override bool IsYakuman => true;

        public override bool IsConditionMet(IEnumerable<TileKinds>? hand, object[]? args = null)
        {
            if (args is null) return false;
            var melds = (List<Meld>)args[0];
            return melds.Count(
                x => x.Type is MeldType.KAN or MeldType.CHANKAN) == 4;
        }
    }
}