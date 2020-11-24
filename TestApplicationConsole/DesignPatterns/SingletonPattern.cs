using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplicationConsole
{
    class CleanCodeDesignPatterns
    {
        private static CleanCodeDesignPatterns _instance = null;
        private CleanCodeDesignPatterns()
        { }
        public static CleanCodeDesignPatterns CreateInstance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new CleanCodeDesignPatterns();
                }
                return _instance;
            }
        }
    }
}
