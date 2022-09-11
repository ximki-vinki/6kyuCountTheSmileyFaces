using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _6kyuCountTheSmileyFaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] smileys = new string[] { ":D", ":~)", ";~D", ":)" };

            var b = smileys.Count(x=> Regex.IsMatch(x, "[:,;]{1}[-,~]{0,1}[D,)]{1}"));
           ;
        }
    }
}
