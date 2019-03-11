namespace Klasser_Singleton
{
    class AppSettings
    {
        public int AppId;
        private static AppSettings o = null;
        private AppSettings() { }
        public static AppSettings HentAppSettings()
        {
            if (o == null)
            {
                o = new AppSettings();
            }
            return o;
        }
}

}
