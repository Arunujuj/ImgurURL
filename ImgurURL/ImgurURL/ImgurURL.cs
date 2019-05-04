using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurURL
{
    public class ImgurURL
    {
        public static string URL_ALPHABET = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private string ToBase62(ulong number)
        {
            var n = number;
            ulong basis = 62;
            var ret = "";
            while (n > 0)
            {
                ulong temp = n % basis;
                ret = URL_ALPHABET[(int)temp] + ret;
                n = (n / basis);

            }
            return ret;
        }

        public string GetImgurURL(string number)
        {
            return ToBase62(Convert.ToUInt32(number));
        }

    }
}
