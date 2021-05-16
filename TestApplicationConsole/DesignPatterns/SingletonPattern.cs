using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationConsole.DesingPatterns
{
    class SingletonPattern
    {
        /// <summary>
        /// Notification: SingletonPattern is no longer an "real" design pattern
        /// </summary>
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
