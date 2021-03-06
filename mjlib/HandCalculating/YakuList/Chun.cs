using mjlib.Tiles;
using System.Collections.Generic;
using System.Linq;

namespace mjlib.HandCalculating.YakuList
{
    internal class Chun : Yaku
    {
        public override int YakuId => 15;

        public override int TenhouId => 20;

        public override string Name => "Yakuhai (chun)";

        public override string Japanese => "役牌(中)";

        public override string English => "Red Dragon";

        public override int HanOpen { get; set; } = 1;

        public override int HanClosed { get; set; } = 1;

        public override bool IsYakuman => false;

        public override bool IsConditionMet(IEnumerable<TileKinds>? hand, object[]? args = null) 
            => hand?.Count(x => x.IsPon && x[0].Value == Constants.CHUN) == 1;
    }
}