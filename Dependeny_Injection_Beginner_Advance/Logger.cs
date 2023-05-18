using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependeny_Injection_Beginner_Advance
{
   class Logger
   {
      public void Log(string message)
      {
         Console.WriteLine($"Logging: {message}");
      }
   }
}
