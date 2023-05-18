using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependeny_Injection_Beginner_Advance
{
   class Program
   {
      static void Main(string[] args)
      {
         var logger = new Logger();  // Create an instance of Logger
         var myClass = new MyClass(logger);  // Inject Logger into MyClass

         myClass.DoSomething();  // Use MyClass with injected Logger

      }
   }
}
