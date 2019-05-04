using System;
using System.Collections.Generic;
using System.Linq;
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
            for(int i = 0; i < URL_COUNT; i++)
            {
                ImgurURL.ImgurURL test = new ImgurURL.ImgurURL();
                Console.WriteLine(test.GetImgurURL(rnd.Next(999999999).ToString()));
            }


            
            Console.ReadLine();
        }
    }
}
