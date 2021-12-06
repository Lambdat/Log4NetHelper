using log4net;
using log4net.Config;
using log4net.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogHelper
{
    public class Log4NetHelper
    {
        public static ILog GetLogger([CallerFilePath] string fileName = "") // il parametro filename è il nome della classe alla quale vogliamo aggiungere il log4net
        {                                                                    //Esso è un parametro opzionale nel caso avessimo più classi all'interno di un file.cs , se cosi non fosse andrebbe bene lasciarlo di default
            ILoggerRepository iLogRepo = LogManager.GetRepository(Assembly.GetEntryAssembly());

            XmlConfigurator.Configure(iLogRepo, new FileInfo("log4net.config")); // Andiamo a specificare il file.xml dove prendere le configurazioni del logger
          
            return LogManager.GetLogger(fileName);   
        }
    }
}
