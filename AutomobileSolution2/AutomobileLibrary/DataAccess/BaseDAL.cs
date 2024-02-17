using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class BaseDAL
    {
        public StockDataProvider dataProvider { get; set; }
        public SqlConnection connection=null;
        public BaseDAL()
        {
            var connectionString=GetConnectionString();
            dataProvider= new StockDataProvider(connectionString);
        }
        public string GetConnectionString()
        {
            string connectionString;
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsetting.json", true, true).Build();
            return connectionString = config["ConnectionString:MyStockDB"];
        }
        public void CloseConnection() => dataProvider.CloseConnection(connection);
    }
}
