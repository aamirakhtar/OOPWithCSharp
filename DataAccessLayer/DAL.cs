using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DAL
    {
        protected internal string connectionString { get; set; }

        public List<string> GetDataFromDB(string connectionString)
        {
            return new List<string>();
        }

        public void SaveDataToDB(string data)
        {
            Console.WriteLine("data saved to db");
        }
    }

    class Temp
    {
        public void Func()
        {
            DAL dal = new DAL();
            dal.connectionString = "dgsaddas";
        }
    }
}