using System.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipNetCore {

    public class StreamCollection : CollectionBase, IEnumerable, IEnumerator {

        private int index = -1;

        public StreamCollection() {
            this.index = -1;
        }

        public void Add(Stream stream) {
            if (stream != null) {
                this.List.Add(stream);
            }
        }

        public void Remove(Stream stream) {
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
