using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class LogginService
    {
        public static void WriteToFile(List<object> itemsToLog)
        {
            foreach (var log in itemsToLog)
            {
                Console.WriteLine(log);
            }
        }
    }
}
