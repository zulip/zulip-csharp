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
        public static string ApiKey => client?.APIKey;

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

        public static async Task GetZulipClient() {
            if (!Connected && !string.IsNullOrEmpty(Password)) {
                ZulipServer ZuSrv = new ZulipServer(ServerURL);
                client = await ZuSrv.LoginAsync(UserEmail, Password);
                Connected = client != null;
            }
        }

        public static void GetZulipClient(string ZulipRCPath) {
            if (!Connected) {
                client = ZulipServer.Login(ZulipRCPath);
                Connected = client != null && !string.IsNullOrEmpty(ApiKey);
            }
        }

        public static async Task GetZulipClient(string userEmail, string password) {
            if (!Connected) {
                ZulipServer ZuSrv = new ZulipServer(ServerURL);
                client = await ZuSrv.LoginAsync(UserEmail, Password);
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
