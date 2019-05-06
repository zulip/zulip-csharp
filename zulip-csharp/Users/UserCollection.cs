using System.Collections;
using System.Collections.Generic;

namespace ZulipAPI {

    public class UserCollection : CollectionBase, IEnumerable, IEnumerator {

        private int index = -1;

        public UserCollection() {
            this.index = -1;
        }

        public void Add(User user) {
            if (user != null) {
                this.List.Add(user);
            }
        }

        public void AddRange(IEnumerable<User> users) {
            if (users != null) {
                foreach (var user in users) {
                    this.List.Add(user);
                }
            }
        }

        public void Remove(User user) {
            this.List.Remove(user);
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
