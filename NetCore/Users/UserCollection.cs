using System.Collections;

namespace ZulipNetCore {

    public class UserCollection : CollectionBase, IEnumerable, IEnumerator {

        private int index = -1;

        public UserCollection() {
            this.index = -1;
        }

        public void Add(User stream) {
            if (stream != null) {
                this.List.Add(stream);
            }
        }

        public void Remove(User stream) {
            this.List.Remove(stream);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this;
        }

        public object Current {
            get {
                return this.List[index];
            }
        }

        public bool MoveNext() {
            this.index++;
            return (this.index < this.List.Count);
        }

        public void Reset() {
            this.index = -1;
        }
    }
}
