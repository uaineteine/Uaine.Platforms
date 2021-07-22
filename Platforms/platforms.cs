namespace Uaine.Platforms
{
    public static class platforms
    {
        public const int windowsdesktop = 0;
        public const int android = 1;
        public const int windowsphone = 2;
        public const int linuxdesktop = 3;
        public const int mac = 4;
        public const int ios = 5;
        public const int rasbian = 6;
        public const int chromeOS = 7;
        public const int dos = 8;
        public const int solaris = 9;
        public const int symbian = 10;

        public static int currentPlatform = windowsdesktop;
        public static void setPlatform(int platID)
        {
            currentPlatform = platID;
        }

        public static bool isDesktop()
        {
            switch(currentPlatform)
            {
                case windowsdesktop:
                case linuxdesktop:
                case mac:
                case rasbian:
                case chromeOS:
                    return true;

                default:
                    return false;
            }
        }

        public static bool isPhoneOS()
        {
            switch (currentPlatform)
            {
                case windowsphone:
                case ios:
                case android:
                    return true;

                default:
                    return false;
            }
        }
    }
}
