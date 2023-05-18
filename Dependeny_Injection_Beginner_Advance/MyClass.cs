using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependeny_Injection_Beginner_Advance
{
   class MyClass
   {
      private readonly Logger _logger;

      public MyClass(Logger logger)
      {
         _logger = logger;
      }

      public void DoSomething()
      {
         _logger.Log("Doing something...");
      }
   }
}
