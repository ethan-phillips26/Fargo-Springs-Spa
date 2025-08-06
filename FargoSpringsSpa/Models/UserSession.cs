namespace FargoSpringsSpa.Models
{
    public static class UserSession
    {
        public static User? CurrentUser { get; private set; }

        public static bool IsLoggedIn => CurrentUser != null;

        public static bool IsAdmin => CurrentUser?.Role == "Admin";

        public static bool IsCustomer => CurrentUser?.Role == "Customer";

        public static void Login(User user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

        public static string GetUserName()
        {
            return CurrentUser?.Name ?? "Guest";
        }

        public static string GetUserRole()
        {
            return CurrentUser?.Role ?? "None";
        }

        public static int GetUserId()
        {
            return CurrentUser?.Id ?? 0;
        }
    }
}