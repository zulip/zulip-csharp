using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZulipAPI;

namespace SampleApp {
    static class Program {

        private static string _serverURL;
        public static string ServerURL {
            get { return _serverURL; }
            set { _serverURL = value; Connected = false; }
        }
        private static string _userEmail;
        public static string UserEmail {
            get { return _userEmail; }
            set { _userEmail = value; Connected = false; }
        }
        private static string _apiKey;
        public static string ApiKey {
            get { return _apiKey; }
            set { _apiKey = value; Connected = false; }
        }
        private static string _password;
        public static string Password {
            get { return _password; }
            set { _password = value; Connected = false; }
        }
        private static bool _connected;
        public static bool Connected {
            get { return _connected; }
            set { _connected = value; }
        }

        public static ZulipClient client;

        public static void GetZulipClient() {
            if (!Connected && !string.IsNullOrEmpty(ApiKey)) {
                ZulipServer ZuSrv = new ZulipServer(ServerURL);
                ZulipAuthentication ZuAuth = new ZulipAuthentication(UserEmail, ApiKey);
                client = new ZulipClient(ZuSrv, ZuAuth);
                Connected = client != null;
            }
        }

        public static void GetZulipClient(string ZulipRCPath) {
            if (!Connected) {
                client = new ZulipClient(ZulipRCPath);
                Connected = client != null && !string.IsNullOrEmpty(ApiKey);
            }
        }

        public static void GetZulipClient(string userEmail, string password) {
            if (!Connected) {
                client = new ZulipClient(ServerURL, userEmail, password);
                var http = client.Login();
                Connected = client != null && !string.IsNullOrEmpty(ApiKey);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SampleApp());
        }
    }
}
