using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ZulipAPI.Messages {

    public class MessageCollection : CollectionBase, IEnumerable, IEnumerator {

        private int index = -1;
        public IList<MessageBase> Items => this.List.Cast<MessageBase>().ToList();

        public MessageCollection() {
            this.index = -1;
        }

        public void Add(MessageBase message) {
            if (message != null) {
                this.List.Add(message);
            }
        }

        public void AddRange(IEnumerable<MessageBase> messages) {
            if (messages != null) {
                foreach (var message in messages) {
                    this.List.Add(message);
                }
            }
        }

        public void Remove(MessageBase message) {
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
