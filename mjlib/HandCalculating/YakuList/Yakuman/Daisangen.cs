using mjlib.Tiles;
using System.Collections.Generic;
using static mjlib.Constants;

namespace mjlib.HandCalculating.YakuList.Yakuman
{
    internal class Daisangen : Yaku
    {
        public override int YakuId => 39;

        public override int TenhouId => 39;

        public override string Name => "Daisangen";

        public override string Japanese => "大三元";

        public override string English => "Big Three Dragons";

        public override int HanOpen { get; set; } = 13;
        public override int HanClosed { get; set; } = 13;

        public override bool IsYakuman => true;

        public override bool IsConditionMet(IEnumerable<TileKinds>? hand, object[]? args = null)
        {
            if (hand is null) return false;
            var countOfDragonPonSets = 0;
            foreach (var item in hand)
            {
                if (item.IsPon && new List<int> { HAKU, HATSU, CHUN }.Contains(item[0].Value))
                {
                    countOfDragonPonSets++;
                }
            }
            return countOfDragonPonSets == 3;
        }
    }
}