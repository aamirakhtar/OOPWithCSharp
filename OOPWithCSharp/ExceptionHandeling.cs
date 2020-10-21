using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithCSharp
{
    class ExceptionHandeling
    {
        public static void Main()
        {
            try
            {
                SomeProcessing();

                Console.WriteLine("aamir");
            }
            catch(SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
            }
            catch(NullReferenceException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (PermissionException pEx)
            {
                Console.WriteLine(pEx.Message);
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
            }

            finally
            {
                Console.ReadLine();
            }
        }

        public static void SomeProcessing()
        {
            try
            {
                string str = null;
                Console.WriteLine(str.ToLower());
            }
            catch
            {
                throw new PermissionException();
            }
        }
    }

    public class PermissionException : Exception
    {
        public override string Message => "There is permission issue";
    }
}
