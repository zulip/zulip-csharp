using System.IO;

namespace ZulipNetCore {

    public class ZulipRCAuth {

        public ZulipAuthentication ZulipAuth { get; private set; }
        public ZulipServer Server { get; private set; }

        public string Username { get; set; }
        public string UserSecret { get; set; }
        public string ServerURL { get; set; }

        public ZulipRCAuth(string ZulipRCPath) {
            LoadZulipRCasString(ZulipRCPath);
        }

        private void LoadZulipRCasString(string ZulipRCPath) {
            string line = "";

            if (File.Exists(ZulipRCPath)) {
                var zuliprc = new StreamReader(ZulipRCPath);
                while ((line = zuliprc.ReadLine()) != null) {
                    if (line.Contains("=")) {
                        var KeyValPair = line.Split('=');
                        switch (KeyValPair[0]) {
                            case "email":
                                Username = KeyValPair[1];
                                break;
                            case "key":
                                UserSecret = KeyValPair[1];
                                break;
                            case "site":
                                ServerURL = KeyValPair[1];
                                break;
                        }
                    }
                }
            } else {
                throw new System.Exception("give me proper error message");
            }

            Server = new ZulipServer(ServerURL);
            ZulipAuth = new ZulipAuthentication(Username, UserSecret);
        }
    }
}
