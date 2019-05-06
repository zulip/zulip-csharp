using Newtonsoft.Json;

namespace ZulipAPI {

    public class User {

        public uint UserID { get; set; }
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsBot { get; set; }
        public string AvatarURL { get; set; }
        public bool IsActive { get; set; }
        public int? BotType { get; set; }
        public bool IsGuest { get; set; }
        public string Email { get; set; }
        public string BotOwner { get; set; }
        public string TimeZone { get; set; }
        public string Password { get; }
        public string Shortname { get; }

        public User() {

        }

        /// <summary>
        /// Constructor is solely for creating a new user.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="shortname"></param>
        /// <param name="fullName"></param>
        public User(string email, string password, string shortname, string fullName) {
            Email = email;
            FullName = fullName;
            Password = password;
            Shortname = shortname;
        }

        //public User(uint StreamID, string Name, string Description, bool InviteOnly) {
        //    this.StreamID = StreamID;
        //    this.Name = Name;
        //    this.Description = Description;
        //    this.InviteOnly = InviteOnly;
        //}

        public override string ToString() {
            return $"{UserID} {FullName}";
        }

    }
}
