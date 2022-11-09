using System;

namespace MusicShop.DomainModel
{
    sealed class Connection
    {
        public static event EventHandler UserChanged;

        public static User Guest { get; } = new User { Role = new Role { RoleName = "Гость" }, IdUser = -1, Login = "гость" };

        private static readonly User admin = new User
        {
            Role = new Role { RoleName = "Администратор" },
            IdUser = -1,
            Login = "root",
            Password = "toor"
        };

        public static User Admin { get => admin; }

        private static User currentUser;

        public static User CurrentUser 
        { 
            get => currentUser ?? Guest;
            set
            {
                if (currentUser == value)
                {
                    return;
                }
                currentUser = value;
                UserChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        private Connection() { }
    }
}
