using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BekraFormating
{
    public class Formatlar
    {
        /// <summary>
        /// Email Verisi.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public List<string> Email_Extract(string text)
        {
            MatchCollection coll = Regex.Matches(text, "([a-zA-Z0-9._-]+@([a-zA-Z0-9_-]+\\.)+[a-zA-Z0-9_-]+)");
            List<string> emails = new List<string>();
            foreach (object obj in coll)
            {
                Match i = (Match)obj;
                bool dgr = !emails.Contains(i.Value.ToString().ToLower());
                if (dgr)
                {
                    emails.Add(i.Value.ToString().ToLower());
                }
            }
            return emails;
        }
        /// <summary>
        /// Telefon Verisi.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public List<string> Telefon_Extract(string text)
        {
            string reg = "(0|0 |\\+90|\\+90 |0090|00 90|\\+ 90|)+((([0-9]{3})+([0-9]{3})+([0-9]{2})+([0-9]{2}))|(([0-9]{3})+ +([0-9]{3})+([0-9]{2})+([0-9]{2}))|(([0-9]{3})+ +([0-9]{3})+ +([0-9]{2})+([0-9]{2}))|(([0-9]{3})+ +([0-9]{3})+ +([0-9]{2})+ +([0-9]{2})))";
            MatchCollection coll = Regex.Matches(text, reg);
            List<string> t = new List<string>();
            foreach (object obj in coll)
            {
                Match i = (Match)obj;
                bool flag = !t.Contains(i.Value.ToString().ToLower());
                if (flag)
                {
                    t.Add(i.Value.ToString().ToLower());
                }
            }
            return t;
        }
    }
}
