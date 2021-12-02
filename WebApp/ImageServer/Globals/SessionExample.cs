namespace WebApp.Image.Globals
{
    public static class SessionExample
    {
        private static ISession _session;
        public static ISession GetSession => _session;

        public static void SetSession(ISession session)
        {
            if (_session == null)
            {
                _session = session;
            }
        }

    }
}
