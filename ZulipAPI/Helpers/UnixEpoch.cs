using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipAPI {

    public static class UnixEpoch {
        //https://stackoverflow.com/questions/2883576/how-do-you-convert-epoch-time-in-c
        public static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    }
}
