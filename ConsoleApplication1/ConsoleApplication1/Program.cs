using System;
using System.IO;
using System.Net;

namespace writedatatofile
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "kanon is bad boy and good student";
            //File.WriteAllText(@"C:\Users\abdul.kuddus\Desktop\data.txt",name);


            WebClient client = new WebClient();
            string reply = client.DownloadString(@"https://www.google.com");
            File.WriteAllText(@"C:\Users\abdul.kuddus\Desktop\data.txt",reply);

            //Console.WriteLine(reply);
        }
    }
}
