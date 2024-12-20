namespace TestApplicationConsole.DesingPatterns
{
    class SingletonPattern
    {
        private static SingletonPattern _instance = null;

        private SingletonPattern()
        { }

        public static SingletonPattern CreateInstance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SingletonPattern();
                }
                return _instance;
            }
        }
    }
}
