using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ImgurURLTester
{
    class Program
    {
        static int URL_COUNT = 10;
        static Random rnd = new Random();
    

        static void Main(string[] args)
        {
            Console.WriteLine("MAX URLS: " + URL_COUNT);
            for(int i = 0; i < URL_COUNT; i++)
            {
                ImgurURL.ImgurURL test = new ImgurURL.ImgurURL();
                string url = test.GetImgurURL(rnd.Next(999999999).ToString());

                switch(CheckURLAvailable(url))
                {
                    case true:
                        Console.WriteLine(i + ": " + url);
                        break;
                    case false:
                        i--;
                        break;
                }
            }
            Console.ReadLine();
        }

        static bool CheckURLAvailable(string url)
        {
            bool isAvailable = false;

            using (WebClient test = new WebClient())
            {
                string fullURL = "https://www.imgur.com/" + url;

                try
                {
                    var html = test.DownloadString(fullURL);
                    isAvailable = true;

                }
                catch(WebException ex)
                {
                    isAvailable = false;
                }

                

            }
            return isAvailable;
        }
    }
}
