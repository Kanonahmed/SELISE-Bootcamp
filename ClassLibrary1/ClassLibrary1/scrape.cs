using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class scrape
    {
        public string getstring(string url)
        {
            return webpage(url);
        }

        public string getstring(string url,string filepath)
        {

            string reply = webpage(url);
            File.WriteAllText(filepath,reply);

            return reply;
        }
        private string webpage(string url)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            return reply;
        }
    }
}
