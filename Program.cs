using System;

using System.Net;
using System.Linq;
using System.Text.RegularExpressions;
namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
        WebClient webClient = new WebClient();
    //download the file 
webClient.DownloadFile("https://jsonplaceholder.typicode.com/users", "test.txt" );
string JSONfile = System.IO.File.ReadAllText("test.txt");
Console.WriteLine(JSONfile);
        }
    }
}
