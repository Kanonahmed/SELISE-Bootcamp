using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string content = File.ReadAllText(@"C:\Users\abdul.kuddus\Desktop\dat.txt");
                Console.WriteLine(content);
                
            }
            
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("file not found");
            }
            catch(DriveNotFoundException ex)
            {
                Console.WriteLine("Drive is not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is a Excepton");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
