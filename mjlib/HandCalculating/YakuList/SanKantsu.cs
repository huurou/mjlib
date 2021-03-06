using mjlib.Tiles;
using System.Collections.Generic;
using System.Linq;

namespace mjlib.HandCalculating.YakuList
{
    internal class SanKantsu : Yaku
    {
        public override int YakuId => 28;

        public override int TenhouId => 27;

        public override string Name => "SanKantsu";

        public override string Japanese => "三槓子";

        public override string English => "Three Kans";

        public override int HanOpen { get; set; } = 2;

        public override int HanClosed { get; set; } = 2;

        public override bool IsYakuman => false;

        public override bool IsConditionMet(IEnumerable<TileKinds>? hand, object[]? args = null)
        {
            if (args is null) return false;
            var melds = (List<Meld>)args[0];
            return melds.Where(x => x.Type is MeldType.KAN or MeldType.CHANKAN)
                        .Count() == 3;
        }
    }
}