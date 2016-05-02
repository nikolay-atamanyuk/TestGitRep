namespace WorkProduct
{
    public class VersionHelper
    {
        private static readonly int _major = 1;
        private static readonly int _minor = 0;

        public static string CurrentVersion()
        {
            return $"{_major}.{_minor}";
        }
    }
}