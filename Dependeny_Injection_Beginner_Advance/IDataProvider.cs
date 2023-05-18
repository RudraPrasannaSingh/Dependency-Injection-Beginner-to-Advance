using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependeny_Injection_Beginner_Advance
{
   public interface IDataProvider
   {
      string GetData();
   }

   public class DatabaseDataProvider : IDataProvider
   {
      private readonly string _connectionString;

      public DatabaseDataProvider(string connectionString)
      {
         _connectionString = connectionString;
      }

      public string GetData()
      {
         // Retrieve data from the database using the connection string
         return "Data from the database";
      }
   }

}
