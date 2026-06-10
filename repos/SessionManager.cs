using RusdiBakery.Models;

namespace RusdiBakery.repos
{
    /// <summary>
    /// Menyimpan data customer yang sedang login secara global (in-memory session).
    /// </summary>
    public static class SessionManager
    {
        public static Customer? CurrentCustomer { get; set; }

        public static bool IsLoggedIn => CurrentCustomer != null;

        public static void Clear() => CurrentCustomer = null;
    }
}