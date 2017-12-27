using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZulipAPI;

namespace SampleApp {
    static class Program {

        public static string ServerURL { get; set; }
        public static string UserEmail { get; set; }
        public static string UserSecret { get; set; }

        public static ZulipClient client;

        public static void GetZulipClient() {
            ZulipServer ZuSrv = new ZulipServer(ServerURL);
            ZulipAuthentication ZuAuth = new ZulipAuthentication(UserEmail, UserSecret);
            client = new ZulipClient(ZuSrv, ZuAuth);
        }

        public static void GetZulipClient(string ZulipRCPath) {
            client = new ZulipClient(ZulipRCPath);
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
