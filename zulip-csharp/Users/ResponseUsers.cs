using System.Collections;
using System.Collections.Generic;

namespace ZulipAPI {

    public class ResponseUsers : ResponseBase {

        public IList<User> Members { get; set; }

    }
}
