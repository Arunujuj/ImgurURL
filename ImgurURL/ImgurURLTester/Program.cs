using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ImgurURL;

namespace ImgurURLTester
{
    class Program
    { 
        static Random rnd = new Random();

        static ImgurURLGrabber grabber = new ImgurURLGrabber();

        static void Main(string[] args)
        {
            while (true)
            {
                OpenURL();
                Console.ReadLine();
            }
        }

        private static void OpenURL()
        {
            bool foundLink = false;

            while(foundLink == false)
            {
                string url = grabber.GetImgurURL(rnd.Next(999999999).ToString());

                if(grabber.CheckURLAvailable(url))
                {
                    System.Diagnostics.Process.Start(url);
                    Console.WriteLine("Press ENTER for next one, or close application");
                    foundLink = true;
                }
            }
        }

        
    }
}
