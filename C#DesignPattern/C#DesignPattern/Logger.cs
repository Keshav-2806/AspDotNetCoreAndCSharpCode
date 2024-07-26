using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_DesignPattern
{
   public class Logger
    {
        private static Logger logger;
        private Logger()
        {
                
        }

        public static Logger GetInstance()
        {
            if (logger==null)
            {
                logger = new Logger();
            }
            return logger;
        }
    }
}
