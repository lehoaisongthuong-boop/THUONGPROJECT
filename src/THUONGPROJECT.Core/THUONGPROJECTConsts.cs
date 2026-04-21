using THUONGPROJECT.Debugging;

namespace THUONGPROJECT
{
    public class THUONGPROJECTConsts
    {
        public const string LocalizationSourceName = "THUONGPROJECT";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7a42c6d27fd943b9b05f56d68a97ed29";
    }
}
