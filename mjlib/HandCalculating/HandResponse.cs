using System.Collections.Generic;

namespace mjlib.HandCalculating
{
    public class HandResponse
    {
        public Cost Cost { get; }
        public int Han { get; }
        public int Fu { get; }
        public List<Yaku> Yaku { get; }
        public string? Error { get; }
        public List<FuDetail> FuDetailSet { get; }

        public HandResponse(Cost? cost = null,
            int han = 0,
            int fu = 0,
            List<Yaku>? yaku = null,
            string? error = null,
            List<FuDetail>? fuDetails = null)
        {
            Cost = cost ?? new(0, 0);
            Han = han;
            Fu = fu;
            Yaku = yaku ?? new();
            Error = error;
            FuDetailSet = fuDetails ?? new();
        }
    }
}