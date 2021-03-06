using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static mjlib.Constants;

namespace mjlib.Tiles
{
    public class TileKinds : IList<TileKind>, IEquatable<TileKinds>, IComparable<TileKinds>
    {
        private readonly List<TileKind> tiles_;

        public int Count => tiles_.Count;

        public bool IsChi =>
            Count == 3
            && this[0].Value == this[1].Value - 1
            && this[1].Value == this[2].Value - 1;

        public bool IsPon =>
            Count == 3
            && this[0].Value == this[1].Value
            && this[1].Value == this[2].Value;

        public bool IsPair =>
            Count == 2;

        public bool IsReadOnly => ((ICollection<TileKind>)tiles_).IsReadOnly;

        public TileKind this[int index]
        {
            get => tiles_[index];
            set => tiles_[index] = value;
        }

        public TileKinds() => tiles_ = new List<TileKind>();

        public TileKinds(IEnumerable<TileKind> tiles) => tiles_ = tiles.ToList();

        public TileKinds(IEnumerable<int> tiles) => tiles_ = tiles.Select(t => new TileKind(t)).ToList();

        public void Add(TileKind item) => tiles_.Add(item);

        public TileKinds AddRange(TileKinds collection)
        {
            var t = tiles_.ToList();
            t.AddRange(collection);
            return new TileKinds(t);
        }

        public bool Contains(TileKind item) => tiles_.Contains(item);

        public int IndexOf(TileKind item) => tiles_.IndexOf(item);

        public void RemoveAt(int index) => tiles_.RemoveAt(index);

        public IEnumerator<TileKind> GetEnumerator() => tiles_.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)tiles_).GetEnumerator();

        public bool ContainsTerminal() => this.Any(x => TERMINAL_INDICES.Contains(x.Value));

        public override bool Equals(object? obj) => obj is TileKinds other && Equals(other);

        public bool Equals(TileKinds? other)
        {
            if (other is null) return false;
            if (Count != other.Count) return false;
            for (var i = 0; i < tiles_.Count; i++)
            {
                if (!this[i].Equals(other[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode() => base.GetHashCode();

        public int CompareTo(TileKinds? other)
        {
            if (other is null) return 1;
            var min = Math.Min(Count, other.Count);
            for (var i = 0; i < min; i++)
            {
                if (this[i].CompareTo(other[i]) > 0) return 1;
                if (this[i].CompareTo(other[i]) < 0) return -1;
            }
            return Count > other.Count ? 1 : Count < other.Count ? -1 : 0;
        }

        public void Insert(int index, TileKind item) => ((IList<TileKind>)tiles_).Insert(index, item);

        public void Clear() => ((ICollection<TileKind>)tiles_).Clear();

        public void CopyTo(TileKind[] array, int arrayIndex) => ((ICollection<TileKind>)tiles_).CopyTo(array, arrayIndex);

        public bool Remove(TileKind item) => ((ICollection<TileKind>)tiles_).Remove(item);
    }
}