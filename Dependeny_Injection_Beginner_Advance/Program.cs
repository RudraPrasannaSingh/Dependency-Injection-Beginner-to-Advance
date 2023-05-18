using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dependeny_Injection_Beginner_Advance
{
   class Program
   {
      static void Main(string[] args)
      {
         //Beginner level

         //var logger = new Logger();  // Create an instance of Logger
         //var myClass = new MyClass(logger);  // Inject Logger into MyClass

         //myClass.DoSomething();  // Use MyClass with injected Logger

         //Intermediate Level

         var serviceProvider = new ServiceCollection()
            .AddSingleton<Logger>()  // Register Logger as a singleton
            .AddTransient<MyClass>()  // Register MyClass with transient lifetime
            .BuildServiceProvider();

         var myClass = serviceProvider.GetRequiredService<MyClass>();

         myClass.DoSomething();
         Console.ReadLine();



      }
   }
}
