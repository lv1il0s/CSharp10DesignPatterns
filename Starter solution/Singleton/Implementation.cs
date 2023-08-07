namespace Singleton
{
    public class Logger
    {
       
        //private static Logger? _instance;

        // Thread-safe approach - we pass action to be called on 1st access, each next time, that instance is returned.
        // Lazy<T>
        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());

        protected Logger()
        {

        }


        public static Logger Instance
        {
            get
            {
                //if (_instance == null)
                //{
                //    _instance = new Logger();
                //}
                //return _instance;
                return _lazyLogger.Value;
            }
        }

        /// <summary>
        /// SingletonOperation
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
