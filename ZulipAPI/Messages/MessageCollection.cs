using System.Collections;

namespace ZulipAPI {

    public class MessageCollection : CollectionBase, IEnumerable, IEnumerator {

        private int index = -1;

        public MessageCollection() {
            this.index = -1;
        }

        public void Add(Message message) {
            if (message != null) {
                this.List.Add(message);
            }
        }

        public void Remove(Message message) {
            this.List.Remove(message);
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
